using System;
using RectEncapApp.Model;

namespace RectEncapApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle r1 = new Rectangle(100, 50, BorderStyle.SOLID);
            PrintDetails(r1);
            Rectangle r2 = new Rectangle(10, 5, BorderStyle.DOTTED);
            PrintDetails(r2);
        }

        private static void PrintDetails(Rectangle r)
        {
            Console.WriteLine("Rectangle Details");
            Console.WriteLine("Width:" + r.GetWidth());
            Console.WriteLine("Height:" + r.GetHeight());
            Console.WriteLine("BorderStyle:" + r.GetBorderStyle());
            Console.WriteLine("Area:" + r.CalculateArea());
        }
    }
}
