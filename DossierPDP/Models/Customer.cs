using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DossierPDP.Models
{
    public class Customer
    { 
        public int CustomerId { get; set; }
        public string CustomerFirstName { get; set; }
        public string  CustomerLastName { get; set; }
        public string Email { get; set; }
        public string Telephonenumber { get; set; }
    }
}
