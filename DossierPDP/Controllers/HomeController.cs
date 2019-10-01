using System;
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
    public class HomeController : Controller
    {
        private readonly IDossierRepository _dossierRepository;
        private readonly IHostingEnvironment hostingEnvironment;

        public HomeController(IDossierRepository dossierRepository,
                       IHostingEnvironment hostingEnvironment)
        {
            _dossierRepository = dossierRepository;
            this.hostingEnvironment = hostingEnvironment;
        }

        public IActionResult Index()
        {
            IEnumerable<Dossier >model = _dossierRepository.GetAllDossier();
            return View(model);
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
