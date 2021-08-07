using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using BankWebApi.Controllers;
using BankWebApi.Models;
using BankLib.Service;
using System.Web.Http;

namespace BankApiControllers.Tests
{
    [TestClass]
    public class TransactionControllerTest
    {
        [TestMethod]
        public void TestForGettingTransactionForAValidAccount()
        {
            TransactionController controller = new TransactionController(new BankService());

            IHttpActionResult result = controller.GeTransactionDetails("anmol03") as IHttpActionResult;

            Assert.IsNotNull(result);
        }


        [TestMethod]
        public void TestForGettingTransactionForAnInValidAccount()
        {
            TransactionController controller = new TransactionController(new BankService());

            IHttpActionResult result = controller.GeTransactionDetails("anmol05") as IHttpActionResult;

            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void TestForDepositTransaction()
        {
            TransactionController controller = new TransactionController(new BankService());

            IHttpActionResult result = controller.DoTransaction("anmol03",new TransactionDTO
            {
                Type = "D",
                Amount = 100
            });

            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void TestForWithdrawTransaction()
        {
            TransactionController controller = new TransactionController(new BankService());

            IHttpActionResult result = controller.DoTransaction("anmol03", new TransactionDTO
            {
                Type = "W",
                Amount = 100
            });
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void TestForTransactionWithInvalidAccount()
        {
            TransactionController controller = new TransactionController(new BankService());

            IHttpActionResult result = controller.DoTransaction("anmol05", new TransactionDTO
            {
                Type = "W",
                Amount = 100
            });
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void TestForWithdrawTransactionWIthBalanceLessThan500()
        {
            TransactionController controller = new TransactionController(new BankService());

            IHttpActionResult result = controller.DoTransaction("anmol03", new TransactionDTO
            {
                Type = "W",
                Amount = 100
            });
            Assert.IsNotNull(result);
        }

    }
}
