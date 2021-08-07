using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using BankWebApi.Controllers;
using BankWebApi.Models;
using BankLib.Service;
using System.Web.Http;

namespace BankApiControllers.Tests
{
    [TestClass]
    public class BankAuthenticationControllerTest
    {
        [TestMethod]
        public void TestForAccountAlreadyExistsWhileRegistration()
        {
            BankAuthenticationController testController = new BankAuthenticationController(new BankService());
           
            IHttpActionResult result = testController.Register(new RegisterDTO
            {
                UName = "anmol03",
                Password = "123456",
                Balance = 500,
                RePassword = "123456"
            }) as IHttpActionResult;

            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void TestForRegistrationSuccessful()
        {
            BankAuthenticationController testController = new BankAuthenticationController(new BankService());

            IHttpActionResult result = testController.Register(new RegisterDTO
            {
                UName = "anmol02",
                Password = "123456",
                Balance = 400,
                RePassword = "123456"
            }) as IHttpActionResult;

            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void TestForBalanceLessThan500WhileRegistration()
        {
            BankAuthenticationController testController = new BankAuthenticationController(new BankService());

            IHttpActionResult result = testController.Register(new RegisterDTO
            {
                UName = "anmol03",
                Password = "123456",
                Balance = 400,
                RePassword = "123456"
            }) as IHttpActionResult;

            Assert.IsNotNull(result);

        }

        [TestMethod]
        public void TestForInvalidCredentialsWhileLogin()
        {
            BankAuthenticationController testController = new BankAuthenticationController(new BankService());

            IHttpActionResult result = testController.Login(new LoginDTO
            {
                UName = "anmol03",
                Password = "111222",
            }) as IHttpActionResult;

            Assert.IsNotNull(result);

        }

        [TestMethod]
        public void TestForLoginSuccessfull()
        {
            BankAuthenticationController testController = new BankAuthenticationController(new BankService());

            IHttpActionResult result = testController.Login(new LoginDTO
            {
                UName = "anmol03",
                Password = "123456",
            }) as IHttpActionResult;

            Assert.IsNotNull(result);

        }

    }
}
