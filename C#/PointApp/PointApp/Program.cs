using System;
using PointApp.Model;

namespace PointApp
{
    class Program
    {
        struct Points
        {
           public int x, y;
        } 
        static void Main(string[] args)
        {
            Console.WriteLine("---------------Using Classes---------------");
            PointClass p1 = new PointClass(5, 10);
            p1.UpdatePoint(10, 5);
            p1.PrintDetails();

            Console.WriteLine("---------------Using Structure---------------");
            Points p;
            p.x = 20;
            p.y = 50;
            Console.WriteLine((p.x) + " " + (p.y));
        }
    }
}
