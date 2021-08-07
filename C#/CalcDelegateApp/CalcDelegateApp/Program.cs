using System;
using System.Collections.Generic;
using System.Text;

namespace CalcDelegateApp
{
    class Program
    {
        delegate void DMathOperation(int x, int y);
        static void Main(string[] args)
        {
            DMathOperation dmath;

            dmath = Add;
            dmath += Sub;
            dmath += Mul;
            dmath(20, 10);
        }

        private static void Add(int x, int y)
        {
            Console.WriteLine((x + y));
        }

        private static void Sub(int x, int y)
        {
            Console.WriteLine((x - y));
        }
        private static void Mul(int x, int y)
        {
            Console.WriteLine((x * y));
        }


    }
}
