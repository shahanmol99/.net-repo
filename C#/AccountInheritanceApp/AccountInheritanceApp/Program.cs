using System;
using AccountInheritanceApp.Model;

namespace AccountInheritanceApp
{
    class Program
    {
        static void Main(string[] args)
        {
            SavingAccount s1 = new SavingAccount(101, "Abcd", 500);
            PrintDetails(s1);
            CurrentAccount c1 = new CurrentAccount(1001, "Xyz");
            PrintDetails(c1);

            s1.Deposit(500);
            PrintDetails(s1);

            try
            {
                s1.Withdraw(700);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine();
            }
            PrintDetails(s1);

            c1.Deposit(500);
            PrintDetails(s1);

            try
            {
                c1.Withdraw(700);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine();
            }
            PrintDetails(c1);


        }

        private static void PrintDetails(Account a)
        {
            Console.WriteLine("Account Info:");
            Console.WriteLine("AccNo: " + a.AccNo);
            Console.WriteLine("AccName: " + a.AccName);
            Console.WriteLine("Balance: " + a.GetBalance);
            Console.WriteLine();
        }
    }
}
