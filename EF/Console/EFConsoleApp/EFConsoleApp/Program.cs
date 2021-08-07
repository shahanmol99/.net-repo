using System;
using System.Linq;
using EFConsoleApp.Model;

namespace EFConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            AurionProDbContext db = new AurionProDbContext();
            Customer c1 = new Customer { ID = "3", Name = "Keth", Location = "Abcd" };
            db.Customers.Add(c1);
            db.SaveChanges();
            Console.WriteLine("Added to database");

            IQueryable<object> query = from customers in db.Customers
                                       select customers;
            foreach(Customer c in query)
            {
                Console.WriteLine(c.ID + " " + c.Name + " " + c.Location);
            }

            var c2 = db.Customers.SingleOrDefault(c => c.Name == c1.Name);
            if(c2!=null)
            {
                c2.Name = "Kevin";
                c2.Location = "Xyz";
                db.SaveChanges();
                Console.WriteLine("Updated Changes to database");
            }

            IQueryable<object> query1 = from customers in db.Customers
                                       select customers;
            foreach (Customer c in query)
            {
                Console.WriteLine(c.ID + " " + c.Name + " " + c.Location);
            }

            

            //var c3 = db.Customers.Where(x => x.Name == c1.Name);
            //db.Customers.Remove(c3.First());
            //db.SaveChanges();
            //Console.WriteLine("Deleted From database");
        }
    }
}
