using System;
using CRUDOperationsApp.Model;

namespace CRUDOperationsApp
{
    class Program
    {
        static void Main(string[] args)
        {
            DoDBOperations(new CustomerDB());
            DoDBOperations(new DepartmentDB());
            DoDBOperations(new InvoiceDB());
        }

        private static void DoDBOperations(ICRUDable x)
        {
            x.Create();
            x.Read();
            x.Update();
            x.Delete();
            Console.WriteLine();
        }
    }
}
