﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DossierPDP.Models;
using DossierPDP.Models.repositories;
using Microsoft.AspNetCore.Hosting;

namespace DossierPDP.Controllers
{
    [Controller]
    public class DossierController : Controller
    {
        private readonly IDossierRepository _dossierRepository;
        private readonly ICustomerRepository _customerRepository;
        private readonly IHostingEnvironment _hostingEnvironment;

        public DossierController(IDossierRepository dossierRepository, ICustomerRepository customerRepository,
                       IHostingEnvironment hostingEnvironment)
        {
            _customerRepository = customerRepository;
            _dossierRepository = dossierRepository;
            _hostingEnvironment = hostingEnvironment;
        }
        [HttpPost]
        public IActionResult DossierCreate(Dossier model)
        {
            if (ModelState.IsValid)
            {
                Dossier newDossier = new Dossier
                {
                    DossierName = model.DossierName,
                    CustomerId = model.CustomerId,
                    PartyType = model.PartyType,
                    DatePlanned = model.DatePlanned,
                    Budget = model.Budget
                };
                IRoomRepository roomRepository = new RoomMockRepository();
                IDinerRepository dinerRepository = new DinerMockRepository();
                ViewBag.Diner = dinerRepository.GetAllDiner();
                ViewBag.Dossier = newDossier;
                ViewBag.Rooms = roomRepository.GetAllRoom();

            }
            return View("DossierBase");
        }

        [HttpGet]
        public IActionResult DossierCreate()
        {
            return View();
        }

        [HttpPost]
        public IActionResult DossierUpdate(Dossier model)
        {
            if (ModelState.IsValid)
            {

                Dossier newDossier = new Dossier
                {
                    DossierName = model.DossierName,
                    CustomerId = model.CustomerId,
                    PartyType = model.PartyType,
                    DatePlanned = model.DatePlanned,
                    Budget = model.Budget,
                    DossierRoomList = model.DossierRoomList,
                    /*DossierRemarksList = model.DossierRemarksList
                    DossierDinersList = model.DossierDinersList*/
                };
                ViewBag.Dossier = newDossier;
            }
            return View("DossierDetails");
        }

    }
}