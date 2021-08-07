using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Http.Cors;
using BankLib.Model;
using BankLib.Service;
using BankWebApi.Models;

namespace BankWebApi.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    [RoutePrefix("api/v1/{uname}")]
    public class TransactionController : ApiController
    {
        IBankService _service;

        public TransactionController(IBankService service)
        {
            _service = service;
        }
        [Route("dotransaction")]
        // GET: Transaction
        public IHttpActionResult DoTransaction(string uname,TransactionDTO transactionDTO)
        {
            Account acc = _service.GetAccountByName(uname);

            if (acc==null)
            {
                return BadRequest("Please Login To Do Transaction");
            }

            Transaction transaction = new Transaction
            {
                TransactionId = Guid.NewGuid(),
                Amount = transactionDTO.Amount,
                Type = transactionDTO.Type,
                Date = DateTime.Now
            };

            bool transactionResult = _service.AddTransaction(acc, transaction);

            if(!transactionResult)
            {
                return BadRequest("Transaction Failed!!!");
            }

            return Ok("Transaction Successfull");
        }

        [Route("gettransaction")]
        // GET: Transaction
        public IHttpActionResult GeTransactionDetails(string uname)
        {
            var transaction = _service.GetTransctionByName(uname);

            if(transaction == null)
            {
                return BadRequest("Please Login To Check Transaction Details");
            }

            return Ok(transaction);
        }
    }
}