using System;
using AccountLib;

namespace AccountCLientApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Account acc = new Account(101, "Kev", 5000);
            acc.BalanceChanged += AccountSubscriber.PrintReciept;
            acc.BalanceChanged += AccountSubscriber.SendSms;

            acc.Deposit(1000);
        }
    }
}
