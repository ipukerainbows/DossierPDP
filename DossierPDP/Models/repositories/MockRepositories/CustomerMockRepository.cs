using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace DossierPDP.Models.repositories
{
    public class CustomerMockRepository : ICustomerRepository
    {
        private readonly List<Customer> _customerList;

        public CustomerMockRepository()
        {
            _customerList = new List<Customer>()
            {
                new Customer() { CustomerId = 1, CustomerFirstName = "Nick", CustomerLastName ="Foulon"},
                new Customer() { CustomerId = 2, CustomerFirstName = "Raf", CustomerLastName ="Gillisjans"},
                new Customer() { CustomerId = 3, CustomerFirstName = "Paul-Henry", CustomerLastName ="Decuvelier"}
            };
        }

        public IEnumerable<Customer> GetAllCustomer()
        {
            return _customerList;
        }

        public Customer GetCustomer(int Id)
        {
            Customer test = _customerList.FirstOrDefault(e => e.CustomerId == Id);
            return test;
        }

        public Customer Add(Customer customer)
        {
            customer.CustomerId = _customerList.Max(e => e.CustomerId) + 1;
            _customerList.Add(customer);
            return customer;
        }

        public Customer Update(Customer customerChanges)
        {
            throw new NotImplementedException();
        }

        public Customer Delete(int id)
        {
            throw new NotImplementedException();
        }
    }
}
