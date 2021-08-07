using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MigrationsAPp.Model;

namespace MigrationsAPp
{
    class Program
    {
        static void Main(string[] args)
        {
            AurionProDbContext db = new AurionProDbContext();
            db.Customers.Add(new Customer { Name = "Anmol", Location = "Vasai" });
            Console.WriteLine("Added");
        }
    }
}
