using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DossierPDP.Models;
using DossierPDP.Models.repositories;
using Microsoft.AspNetCore.Mvc;

namespace DossierPDP.Controllers
{
    [Route("[controller]")]
    public class CustomerController : Controller
    {
        private readonly ICustomerRepository _customerRepository;

        public CustomerController(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }

        [HttpGet] 
        [Route("")]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        [Route("Customers")]
        public IActionResult Customers() {

            IEnumerable<Customer> model = _customerRepository.GetAllCustomer(); 
            return View(model);
        }

        [HttpGet]
        [Route("Create")]
        public IActionResult Create()
        {
            return View();
        }

    }
}