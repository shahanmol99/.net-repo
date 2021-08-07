using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using CustomerLib.Model;
namespace CustomerLib.Repo
{
    public class CustomerRepositoryDbContext : DbContext, ICustomerRepositoryDbContext
    {
        public CustomerRepositoryDbContext()
        {
            Database.SetInitializer<CustomerRepositoryDbContext>(new CreateDatabaseIfNotExists<CustomerRepositoryDbContext>());
        }

        public DbSet<Customer> customers { get; set; }

        public void Add(Customer customer)
        {
            customers.Add(customer);
            this.SaveChanges();
        }

        public List<Customer> Get()
        {
            return customers.ToList<Customer>();
        }

        public void Delete(Customer customer)
        {
            customers.Remove(customers.Find(customer.ID));
            this.SaveChanges();
        }

        public void Update(Customer customer)
        {
            this.Entry(customers.Find(customer.ID)).CurrentValues.SetValues(customer);
            this.SaveChanges();
        }
    }
}
