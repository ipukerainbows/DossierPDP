using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DossierPDP.Models;
using DossierPDP.Models.repositories;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;

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
                IDinerRepository dinerRepository = new DinerMockRepository();
                ViewBag.Diner = dinerRepository.GetAllDiner();
                ViewBag.Dossier = newDossier;
                HttpContext.Session.SetString("Dossier", JsonConvert.SerializeObject(newDossier));
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

        [HttpGet]
        public IActionResult DossierKiesZaal()
        {
            Dossier tempDossier = JsonConvert.DeserializeObject<Dossier>(HttpContext.Session.GetString("Dossier"));
            ViewBag.Dossier = tempDossier;
            IRoomRepository roomRepository = new RoomMockRepository();
            ViewBag.Rooms = roomRepository.GetAllRoom();
            return View();
        }
        [HttpPost]
        public IActionResult DossierKiesZaal(Room model)
        {
            if (ModelState.IsValid)
            {
                Debug.WriteLine(model.RoomName);
                Dossier tempDossier = JsonConvert.DeserializeObject<Dossier>(HttpContext.Session.GetString("Dossier"));
                if (tempDossier.DossierRoomList == null)
                {
                    tempDossier.DossierRoomList = new List<Room>();
                    tempDossier.DossierRoomList.Add(model);
                }
                else
                {
                    tempDossier.DossierRoomList.Add(model);
                }
                HttpContext.Session.SetString("Dossier", JsonConvert.SerializeObject(tempDossier));
                ViewBag.Dossier = tempDossier;
            }
            return View("DossierBase");
        }
        [HttpGet]
        public IActionResult DossierKiesReceptie()
        {
            return View();
        }
        [HttpGet]
        public IActionResult DossierKiesDiner()
        {
            Dossier tempDossier = JsonConvert.DeserializeObject<Dossier>(HttpContext.Session.GetString("Dossier"));
            ViewBag.Dossier = tempDossier;
            IDinerRepository dinerRepository = new DinerMockRepository();
            ViewBag.Diner = dinerRepository.GetAllDiner();
            return View();
        }
        [HttpPost]
        public IActionResult DossierKiesDiner(Diner model)
        {
            if (ModelState.IsValid)
            {
                Debug.WriteLine(model.DinerId);
                Dossier tempDossier = JsonConvert.DeserializeObject<Dossier>(HttpContext.Session.GetString("Dossier"));
                if (tempDossier.DossierDinersList == null)
                {
                    Debug.WriteLine("Makes new Dinerlist");
                    tempDossier.DossierDinersList = new List<Diner>();
                    tempDossier.DossierDinersList.Add(model);
                    Debug.WriteLine(tempDossier.DossierDinersList.Count);
                }
                else
                {
                    Debug.WriteLine("Already existing Dinerlist");
                    tempDossier.DossierDinersList.Add(model);
                    Debug.WriteLine(tempDossier.DossierDinersList.Count);
                }
                HttpContext.Session.SetString("Dossier", JsonConvert.SerializeObject(tempDossier));
                ViewBag.Dossier = tempDossier;
            }
            return View("DossierBase");
        }

    }
}
