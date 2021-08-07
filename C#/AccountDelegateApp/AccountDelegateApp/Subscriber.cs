using System;
using AccountDelegateApp.Model;
namespace AccountDelegateApp
{
    class Subscriber
    {
        public static void RefreshBalance(Account acc)
        {
            Console.WriteLine("Refreshing Balance of Account Holder: " + acc.AccName + "........\n" + "Your Current Balance is: " + acc.Balance);
        }

        public static void PrintReciept(Account acc)
        {
            Console.WriteLine("Printing Reciept......\n" + acc.AccName + "Your Current Balance is: " + acc.Balance);
        }

        public static void SendSms(Account acc)
        {
            Console.WriteLine("Sending Sms to " + acc.AccName + "........\n" + "Your Current Balance is: " + acc.Balance);

        }


    }
}
