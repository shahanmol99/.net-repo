using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BankApp.Data;
using BankApp.Models;

namespace BankApp.Controllers
{
    public class AbcdBankController : Controller
    {
        // GET: AbcdBank
        IDataAccess bankDb;

        public AbcdBankController()
        {
            bankDb = new BankSqlDB();
        }

        public ActionResult Main()
        {
            if(Session["loggedInUser"]!=null)
            {
                return RedirectToAction("Welcome");
            }

            return View();

        }

        public ActionResult Welcome()
        {
            if(Session["loggedInUser"]==null)
            {
                return RedirectToAction("Main");
            }

            return View();
        }

        [HttpPost]
        public ActionResult Logout()
        {
            Session["loggedInUser"] = null;
            return RedirectToAction("Main");
        }
        [HttpGet]
        public ActionResult DoTransaction()
        {
            if (Session["loggedInUser"] != null)
            {
                return View(new TransactionModel());
            }

            return RedirectToAction("Main");
            
        }

        [HttpPost]
        public ActionResult DoTransaction(TransactionModel transaction)
        {
            if(!ModelState.IsValid)
            {
                return View(transaction);
            }

            int balance = bankDb.GetBalance(Session["loggedInUser"].ToString());

            if(transaction.Type == "D")
            {
                transaction.AmountErrorMessage = "";
                balance = balance + transaction.Amount;
                bool transactionResult = bankDb.DoTransaction(Session["loggedInUser"].ToString(), balance, transaction.Type, transaction.Amount);
                
                if(transactionResult)
                {
                    transaction.Status = "Successfull";
                    return View(transaction);
                }


                transaction.Status = "Fail";
                return View(transaction);
            }


            if (transaction.Type == "W")
            {
                balance = balance - transaction.Amount;

                if(balance < 500)
                {
                    transaction.AmountErrorMessage = "Minimum Balance Must be 500";
                    return View(transaction);
                }

                transaction.AmountErrorMessage = "";
                bool transactionResult = bankDb.DoTransaction(Session["loggedInUser"].ToString(), balance, transaction.Type, transaction.Amount);
                
                if (transactionResult)
                {
                    transaction.Status = "Successfull";
                    return View(transaction);
                }

                transaction.Status = "Fail";
                return View(transaction);
            }
            transaction.AmountErrorMessage = "";
            transaction.Status = "";
            return Content("Fail");
        }

        public ActionResult ViewPassBook()
        {
            if (Session["loggedInUser"] == null)
            {
                return RedirectToAction("Main");
            }

            string passBookDetails = bankDb.GetTransactionDetails(Session["loggedInUser"].ToString());
            string[] passBookDetailsArr = passBookDetails.Split('\n');
            ViewBag.passBookString = passBookDetailsArr;
            return View();
        }

        [HttpPost]
        public ActionResult Export()
        {
            string passBookDetails = bankDb.GetTransactionDetails(Session["loggedInUser"].ToString());
            StringWriter sw = new StringWriter();

            Response.ClearContent();
            Response.AddHeader("content-disposition", "attachment;filename=PassBookDetails.csv");
            Response.ContentType = "text/csv";

            sw.WriteLine(passBookDetails);
            
            Response.Write(sw.ToString());

            Response.End();

            return RedirectToAction("ViewPassBook");

        }

    }
}