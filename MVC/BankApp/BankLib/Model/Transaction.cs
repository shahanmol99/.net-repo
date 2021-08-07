using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankLib.Model
{
    class Transaction
    {

        public string UserName { get; set; }
        public double Amount { get; set; }
        public string TransactionType { get; set; }
        public string TransactionDate { get; set; }

    }
}
