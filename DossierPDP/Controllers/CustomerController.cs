using DossierPDP.Models;
using DossierPDP.Models.repositories;
using DossierPDP.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace DossierPDP.Controllers
{
    [Route("[controller]/[action]")]
    public class CustomerController : Controller
    {
        private readonly ICustomerRepository _customerRepository;

        public CustomerController(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }

        public IActionResult Index()
        {
            IEnumerable<Customer> model = _customerRepository.GetAllCustomer();
            return View(model);
        }

        [Route("{id?}")]
        public IActionResult Details(int Id)
        {

            Customer model = _customerRepository.GetCustomer(Id);
            return View(model);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Customer customer)
        {
            if (ModelState.IsValid)
            {
                Customer newCustomer = _customerRepository.Add(customer);
            }
            return View();
        }
    }
}