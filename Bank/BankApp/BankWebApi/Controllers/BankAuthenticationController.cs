using BankWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using BankLib.Model;
using BankLib.Service;
using System.Security.Cryptography;
using System.Text;
using System.Net;
using System.Web.Http.Cors;

namespace BankWebApi.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    [RoutePrefix("api/v1/Authentication")]
    public class BankAuthenticationController : ApiController
    {
        IBankService _service;

        public BankAuthenticationController(IBankService service)
        {
            _service = service;
        }

        // GET: BankAuthentication
        [Route("api/v1/authentication/register")]
        public IHttpActionResult Register(RegisterDTO registerDTO)
        {
            if(!ModelState.IsValid)
            {
                return BadRequest("Please Fill All Details");
            }

            if(_service.GetAccountByName(registerDTO.UName)!=null)
            {
                return BadRequest("User Already Exists");
            } 

            string hashPassword = GenrateHashPassword(registerDTO.Password);
            Account acc = new Account { UName = registerDTO.UName, Balance = registerDTO.Balance, Password = hashPassword };
            Transaction transaction = new Transaction
            {
                TransactionId = Guid.NewGuid(),
                Amount = registerDTO.Balance,
                Type = "D",
                Date = DateTime.Now,
                Account = acc
            };

            if (_service.RegisterBankAccount(acc, transaction))
            {
                return Ok("Successfully Registered");
            }

            return BadRequest("Please Try Again");
        }

        [Route("api/v1/authentication/login")]
        public IHttpActionResult Login(LoginDTO logindto)
        {
            if(!ModelState.IsValid)
            {
                return BadRequest("Please Fill All Details");
            }

            Account acc = _service.GetAccountByName(logindto.UName);
            string hashPassword = GenrateHashPassword(logindto.Password);

            if(acc!=null && hashPassword == acc.Password)
            {
                return Ok("Login Successful");
            }
            return BadRequest("Invalid Credentials");
        }

        private string GenrateHashPassword(string password)
        {
            SHA1CryptoServiceProvider sha1 = new SHA1CryptoServiceProvider();
            byte[] passwordBytes = Encoding.ASCII.GetBytes(password);
            byte[] encryptedPasswordBytes = sha1.ComputeHash(passwordBytes);
            return Convert.ToBase64String(encryptedPasswordBytes);
        }
    }
}