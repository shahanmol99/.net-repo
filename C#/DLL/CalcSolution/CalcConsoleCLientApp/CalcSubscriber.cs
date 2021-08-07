using System;
using System.Collections.Generic;
using System.Text;

namespace CalcConsoleCLientApp
{
    class CalcSubscriber
    {
        public static void PrintResult(int result)
        {
            Console.WriteLine("Addition Completed.....\n" + "Result: " + result);
        }

        public static void GenratePdf(int result)
        {
            Console.WriteLine("Genrating Pdf....\n" + "Result: " + result);
        }

    }
}
