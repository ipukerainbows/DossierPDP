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

        public IActionResult Customers()
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
        public IActionResult Create(CustomerCreateViewModel model)
        {
            if (ModelState.IsValid)
            {
                Customer newCustomer = new Customer
                {
                    CustomerFirstName = model.CustomerFirstName,
                    CustomerLastName = model.CustomerLastName,
                    Email = model.Email,
                    Telephonenumber = model.Telephonenumber
                };

                _customerRepository.Add(newCustomer);            

                return RedirectToAction("customers");
                //return RedirectToAction("customers", new { id = newCustomer.CustomerId });
            }
            return View();
        }
    }
}