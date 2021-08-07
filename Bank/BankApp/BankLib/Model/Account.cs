using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BankLib.Model
{
    public class Account
    {
        [Key]
        public string UName { get; set; }
        public string Password { get; set; }
        public double Balance { get; set; }

        public virtual List<Transaction> Transactions { get; set; }
    }
}
