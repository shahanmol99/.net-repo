using System;
using AccountDelegateApp.Model;

namespace AccountDelegateApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Account a1 = new Account(101, "Dev", 5000);
            a1.BalanceChanged += Subscriber.SendSms;
            a1.Deposit(1000);
        }
    }
}
