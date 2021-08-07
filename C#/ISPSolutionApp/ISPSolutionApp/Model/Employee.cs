using System;
using System.Collections.Generic;
using System.Text;

namespace ISPSolutionApp.Model
{
    class Employee : IWorkerWork,IWorkerEat
    {
        public void StartEat()
        {
            Console.WriteLine("Employee Started Eating");
        }

        public void StartWork()
        {
            Console.WriteLine("Robot Started Working");
        }

        public void StopEat()
        {
            Console.WriteLine("Employee Stopped Eating");
        }

        public void StopWork()
        {
            Console.WriteLine("Robot Stopped Working");
        }

    }
}
