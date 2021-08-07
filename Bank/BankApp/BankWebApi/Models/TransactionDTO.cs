using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BankWebApi.Models
{
    public class TransactionDTO
    {
        [Required]
        public double Amount { get; set; }
        [Required]
        public string Type { get; set; }
    }
}