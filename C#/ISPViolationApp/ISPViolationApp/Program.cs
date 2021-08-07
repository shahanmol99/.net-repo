using System;
using ISPViolationApp.Model;

namespace ISPViolationApp
{
    class Program
    {
        static void Main(string[] args)
        {
            DoWorkerOperations(new Employee());
            DoWorkerOperations(new Robot());
        }

        private static void DoWorkerOperations(IWorker worker)
        {
            worker.StartWork();
            worker.StopWork();
            worker.StartEat();
            worker.StopEat();
            Console.WriteLine();
        }
    }
}
