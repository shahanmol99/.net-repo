using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BankApp.Models;
using BankApp.Data;
using System.Security.Cryptography;
using System.Text;

namespace BankApp.Controllers
{
    public class AbcdBankAuthenticationController : Controller
    {
        IDataAccess bankDb;

        public AbcdBankAuthenticationController()
        {
            this.bankDb = new BankSqlDB();
        }

        public ActionResult Main()
        {
            return View();
        }
        public ActionResult Login()
        {
            if (Session["loggedInUser"] != null)
            {
                return RedirectToAction("Welcome", "AbcdBank");
            }

            return View(new BankUserModel());
        }

        [HttpPost]
        public ActionResult Login(BankUserModel bankuser)
        {
            if (!ModelState.IsValid)
            {
                return View(bankuser);
            }

            if(!bankDb.CheckNameExists(bankuser.Name))
            {
                bankuser.NameErrorMessage = "Invalid Username";
                return View(bankuser);
            }

            SHA1CryptoServiceProvider sha1 = new SHA1CryptoServiceProvider();
            byte[] passwordBytes = Encoding.ASCII.GetBytes(bankuser.Password);
            byte[] encryptedPasswordBytes = sha1.ComputeHash(passwordBytes);
            string encrptedPassword = Convert.ToBase64String(encryptedPasswordBytes);

            if (!bankDb.MatchPassword(bankuser.Name, encrptedPassword))
            {
                bankuser.PasswordErrorMessage = "Please Enter Correct Password";
                return View(bankuser);
            }

            Session["loggedInUser"] = bankuser.Name;
            return RedirectToAction("Welcome", "AbcdBank", bankuser);
        }

        public ActionResult Register()
        {
            return View(new RegistrationViewModel());
        }

        [HttpPost]
        public ActionResult Register(RegistrationViewModel rvm)
        {
            if(!ModelState.IsValid)
            {
                rvm.NameErrorMessage = "";
                return View(rvm);
            }


            if(bankDb.CheckNameExists(rvm.Name))
            {
                rvm.NameErrorMessage = "Username Already Exists" ;
                return View(rvm);
            }

            SHA1CryptoServiceProvider sha1 = new SHA1CryptoServiceProvider();
            byte[] passwordBytes = Encoding.ASCII.GetBytes(rvm.Password);
            byte[] encryptedPasswordBytes = sha1.ComputeHash(passwordBytes);
            string encrptedPassword = Convert.ToBase64String(encryptedPasswordBytes);

            //var hashPassword = rvm.Password.GetHashCode();
            bool registrationResult =  bankDb.RegisterBankUser(rvm.Name, rvm.Balance, encrptedPassword);

            if(!registrationResult)
            {
                rvm.RegisterSuccessMessage = "";
                rvm.RegisterErrorMessage = "Err!!! Something Went Wrong Pls Try Again";
                return View(rvm);
            }

            rvm.NameErrorMessage = "";
            rvm.RegisterSuccessMessage = "Registered Successfully Pls Login";
            return View(rvm);
        }
    }
}