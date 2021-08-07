using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace BankLib.Model
{
    public class Transaction
    {
        [Key]
        public Guid TransactionId { get; set; }
        public double Amount { get; set; }
        public string Type { get; set; }
        public DateTime Date { get; set; }

        public virtual Account Account { get; set; }
    }
}
