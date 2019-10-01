using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DossierPDP.Models;

namespace DossierPDP.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            Dossier dossier1 = new Dossier
            {
                Id = 1,
                Name = "PirateParty",
                CustomerID = 1,
                PartyType = PartyType.optie1
            };

            return View("DetailsDossier", dossier1);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
