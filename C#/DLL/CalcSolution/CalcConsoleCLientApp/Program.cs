using System;
using CalcLib;

namespace CalcConsoleCLientApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();
            //Console.WriteLine(calculator.CheckEven(5));

            calculator.AddCompletion += CalcSubscriber.PrintResult;
            calculator.AddCompletion += CalcSubscriber.GenratePdf;

            calculator.Add(5, 40);            
        }
    }
}
