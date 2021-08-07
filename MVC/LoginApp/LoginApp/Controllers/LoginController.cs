using LoginApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LoginApp.Controllers
{
    public class LoginController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Index1()
        {
            LoginViewModel vm = new LoginViewModel();
            vm.UsernName = "UserName";
            vm.UserPassWord = "****";
            return View(vm);
        }

        [HttpPost]
        public ActionResult DoLogin(string username, string password)
        {
            return Content("This are the values you entered username: " + username + " password: " + password);
        }

        [HttpPost]
        public ActionResult Index1(LoginViewModel vm)
        {
            if(vm.UsernName==null || vm.UserPassWord==null)
            {
                vm.ErrorMessage = "Please Fill all the fields";
                return View(vm);
            }

            Session["username"] = vm.UsernName;
            return Redirect("/Login/Welcome");
        }

        public ActionResult Welcome()
        {
            return View();
        }
    }
}