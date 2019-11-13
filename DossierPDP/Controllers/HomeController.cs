using DossierPDP.Models;
using DossierPDP.Models.repositories;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace DossierPDP.Controllers
{
    [Route("")]
    [Route("[controller]")]
    public class HomeController : Controller
    {
        private readonly IDossierRepository _dossierRepository;
        private readonly IHostingEnvironment _hostingEnvironment;

        public HomeController(IDossierRepository dossierRepository,
                       IHostingEnvironment hostingEnvironment)
        {
            _dossierRepository = dossierRepository;
            _hostingEnvironment = hostingEnvironment;
        }

        [Route("")]
        public IActionResult Index()
        {
            IEnumerable<Dossier> model = _dossierRepository.GetAllDossier();
            return View(model);
        }

    }
}
