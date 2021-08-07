using System;
using System.Collections.Generic;
using System.Text;

namespace ISPSolutionApp.Model
{
    class Robot : IWorkerWork
    {
        public void StartWork()
        {
            Console.WriteLine("Robot Started Working");
        }

        public void StopWork()
        {
            Console.WriteLine("Robot Stopped Working");
        }
    }
}
