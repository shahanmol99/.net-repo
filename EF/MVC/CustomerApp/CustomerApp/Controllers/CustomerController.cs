using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CustomerLib.Service;
using CustomerLib.Model;
using CustomerApp.Models;
using System.Web.Security;

namespace CustomerApp.Controllers
{
    public class CustomerController : Controller
    {
        ICustomerService _service;

        public CustomerController(ICustomerService service)
        {
            _service = service;
        }

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult VerifyUser()
        {
            if(Request.Form["uname"]=="admin" && Request.Form["password"]=="admin")
            {
                FormsAuthentication.SetAuthCookie(Request.Form["uname"], false);
                return RedirectToAction("Index");
            }
            return RedirectToAction("Login");
        }
        // GET: Customer
        public ActionResult Index()
        {
            List<Customer> customers = _service.GetCustomers();
            return View(customers);
        }

        public ActionResult Add()
        {
            return View(new AddViewModel());
        }

        [HttpPost]
        public ActionResult Add(AddViewModel vm)
        {
            if(!ModelState.IsValid)
            {
                return View(vm);
            }
            _service.AddCustomer(new Customer { ID = Guid.NewGuid().ToString(), Name = vm.Name, Location = vm.Location });
            return RedirectToAction("Index");
        }

        [Authorize]
        public ActionResult Update(Customer customer)
        {
            return View(new UpdateViewModel { ID = customer.ID, Name = customer.Name, Location = customer.Location });
        }

        [HttpPost]
        public ActionResult Update(UpdateViewModel vm)
        {
            if (!ModelState.IsValid)
            {
                return View(vm);
            }
            _service.UpdateCustomerDetails(new Customer { ID = vm.ID, Name = vm.Name, Location = vm.Location });
            return RedirectToAction("Index");
        }

        [Authorize]
        public ActionResult Delete(Customer customer)
        {
            _service.DeleteCustomer(customer);
            return RedirectToAction("Index");
        }
    }
}