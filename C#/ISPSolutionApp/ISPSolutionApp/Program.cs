using System;
using ISPSolutionApp.Model;

namespace ISPSolutionApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee();
            emp.StartWork();
            emp.StopWork();
            emp.StartEat();
            emp.StopEat();

            Console.WriteLine();

            Robot robo = new Robot();
            robo.StartWork();
            robo.StopWork();

        }
    }
}
