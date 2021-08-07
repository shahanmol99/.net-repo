using System;
using RectangleWithProperties.Model;

namespace RectangleWithProperties
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle r1 = new Rectangle(100, 50);
            PrintDetails(r1);
            r1.Border = BorderStyle.DOTTED;
            PrintDetails(r1);
        }

        private static void PrintDetails(Rectangle r1)
        {
            Console.WriteLine("Rectangle Details");
            Console.WriteLine("Width: " + r1.Width);
            Console.WriteLine("Height: " + r1.Height);
            Console.WriteLine("BorderStyle: " + r1.Border);
            Console.WriteLine("Area: "+r1.CalculateArea());
        }
    }
}
