using CustomerLib.Model;
using System.Collections.Generic;
using System.Data.Entity;

namespace CustomerLib.Repo
{
    public interface ICustomerRepositoryDbContext
    {
        DbSet<Customer> customers { get; set; }

        void Add(Customer customer);
        void Delete(Customer customer);
        List<Customer> Get();
        void Update(Customer customer);
    }
}