using System;
using AccountApp.Model;
using AccountApp.Data;

namespace AccountApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Account a1 = new Account(101, "Anmol");
            DataSerialization ds = new DataSerialization();

            PrintDetails(a1);
            
            a1.Deposit(500);
            PrintDetails(a1);

            try
            {
                a1.Withdraw(700);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine();
            }
            PrintDetails(a1);

            Console.WriteLine("Account Before Serialization");
            PrintDetails(a1);
            ds.Serialization(a1);
            Account a = (Account)ds.Deserialization();
            Console.WriteLine("Account After Serialization");
            PrintDetails(a);
        }

        private static void PrintDetails(Account a)
        {
            Console.WriteLine("Account Info:");
            Console.WriteLine("AccNo: " + a.AccNo);
            Console.WriteLine("AccName: " + a.AccName);
            Console.WriteLine("Balance: " + a.Balance);
            Console.WriteLine();
        }
    }
}
