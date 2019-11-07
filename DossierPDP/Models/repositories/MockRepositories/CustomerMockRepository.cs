using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DossierPDP.Models.repositories
{
    public class CustomerMockRepository : ICustomerRepository
    {
        private List<Customer> _customerList;
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
    }
}
