using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;
using RegistrationApp.Models;
using RegistrationApp.Filters;

namespace RegistrationApp.Controllers
{
    public class RegistrationController : Controller 
    {
        [HttpGet]
        [TrackExecutionTime]
        public ActionResult Index()
        {
            return View(new RegistrationViewModel());
        }

        [HttpPost]
        public ActionResult Index(RegistrationViewModel vm)
        {
            if (!ModelState.IsValid)
            {
                return View(vm);
            }
            StringBuilder thankyouMsg = new StringBuilder();
            thankyouMsg.Append("Hello Mr." + vm.Name);
            thankyouMsg.Append("\n");
            thankyouMsg.Append("Thankyou for registering we will be in touch we you at " + vm.Email);

            return Content(thankyouMsg.ToString());
        }
    }
}