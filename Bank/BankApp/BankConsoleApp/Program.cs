using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BankLib.Model;
using BankLib.Service;

namespace BankConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.ReadLine();
            BankService _service = new BankService();

            Account acc = new Account { UName = "ppp", Balance = 500, Password = "123456" };

            Transaction transaction = new Transaction
            {
                TransactionId = Guid.NewGuid(),
                Amount = acc.Balance,
                Type = "D",
                Date = DateTime.Now,
                Account = acc
            };

            acc.Transactions = new List<Transaction>();
            acc.Transactions.Add(transaction);

            bool res = _service.RegisterBankAccount(acc, transaction);

            if (res)
            {
                Console.WriteLine("Sucessfully Added");
            }
            else
            {
                Console.WriteLine("Failed!!!!");
            }

            var list = _service.GetAccounts();
            foreach(var a in list)
            {
                Console.WriteLine(a.Transactions.Count);
            }
        }
    }
}
