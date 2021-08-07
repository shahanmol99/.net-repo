using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BankApp.Models
{
    public class TransactionModel
    {
        [Required(ErrorMessage = "Please Enter The Amount")]
        public int Amount { get; set; }

        [Required(ErrorMessage = "Please Choose A Transaction Type")]
        public string Type { get; set; }
        public string Status { get; internal set; }
        public string AmountErrorMessage { get; internal set; }
    }
}