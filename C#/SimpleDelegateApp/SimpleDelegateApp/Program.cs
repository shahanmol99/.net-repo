using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleDelegateApp
{
    class Program
    {
        delegate void DPrintMessage(String name);
        static void Main(string[] args)
        {
            DPrintMessage msg;

            msg = PrintHello;
            msg += PrinGoodBye;
            msg += foo;
            msg("Anmol");
        }

        private static void PrintHello(String name)
        {
            Console.WriteLine("Hello " + name);
        }

        private static void PrinGoodBye(String name)
        {
            Console.WriteLine("GoodBye " + name);
        }

        private static void foo()
        {
            Console.WriteLine("Inside Foo");
        }

    }
}
