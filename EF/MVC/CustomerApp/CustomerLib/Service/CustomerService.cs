using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CustomerLib.Model;
using CustomerLib.Repo;

namespace CustomerLib.Service
{
    public class CustomerService : ICustomerService
    {
        ICustomerRepositoryDbContext _repo;
        public CustomerService(ICustomerRepositoryDbContext repo)
        {
            _repo = repo;
        }

        public void AddCustomer(Customer customer)
        {
            _repo.Add(customer);
        }

        public List<Customer> GetCustomers()
        {
            return _repo.Get();
        }

        public void DeleteCustomer(Customer customer)
        {
            _repo.Delete(customer);
        }

        public void UpdateCustomerDetails(Customer customer)
        {
            _repo.Update(customer);
        }
    }
}
