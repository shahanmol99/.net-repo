using System;
using System.Collections.Generic;
using System.Text;

namespace ISPViolationApp.Model
{
    class Employee : IWorker
    {
        public void StartEat()
        {
            Console.WriteLine("Employee Started Eating");
        }

        public void StartWork()
        {
            Console.WriteLine("Employee Started Working");
        }

        public void StopEat()
        {
            Console.WriteLine("Employee Stopped Eating");
        }

        public void StopWork()
        {
            Console.WriteLine("Employee Stopped Working");
        }
    }
}
