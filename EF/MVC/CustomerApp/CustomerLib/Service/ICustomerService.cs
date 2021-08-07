using CustomerLib.Model;
using System.Collections.Generic;

namespace CustomerLib.Service
{
    public interface ICustomerService
    {
        void AddCustomer(Customer customer);
        void DeleteCustomer(Customer customer);
        List<Customer> GetCustomers();
        void UpdateCustomerDetails(Customer customer);
    }
}