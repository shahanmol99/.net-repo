using System;
using System.Collections.Generic;
using System.Text;

namespace ISPViolationApp.Model
{
    class Robot : IWorker
    {
        public void StartEat()
        {
            Console.WriteLine("Errrr!!! Robots Can't Eat");
        }

        public void StartWork()
        {
            Console.WriteLine("Employee Started Working");
        }

        public void StopEat()
        {
            Console.WriteLine("Errrr!!! Robots Can't Eat");
        }

        public void StopWork()
        {
            Console.WriteLine("Employee Stopped Working");
        }

    }
}
