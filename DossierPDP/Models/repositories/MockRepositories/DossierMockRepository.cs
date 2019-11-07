using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DossierPDP.Models.repositories
{
    public class DossierMockRepository :IDossierRepository
    {
        private List<Dossier> _dossierList;
        public DossierMockRepository()
        {
            _dossierList = new List<Dossier>()
            {
                new Dossier() { DossierId = 1, DossierName = "Dossier 1" , CustomerId = 1, DatePlanned = new DateTime(2017, 1, 1) },
                new Dossier() { DossierId = 2, DossierName = "Dossier 2" , CustomerId = 2, DatePlanned = new DateTime(2017, 1, 2) },
                new Dossier() { DossierId = 3, DossierName = "Dossier 3" , CustomerId = 2, DatePlanned = new DateTime(2017, 1, 3) },
                new Dossier() { DossierId = 4, DossierName = "Dossier 4" , CustomerId = 1, DatePlanned = new DateTime(2017, 1, 1) },
                new Dossier() { DossierId = 5, DossierName = "Dossier 5" , CustomerId = 2, DatePlanned = new DateTime(2017, 1, 2) },
                new Dossier() { DossierId = 6, DossierName = "Dossier 6" , CustomerId = 2, DatePlanned = new DateTime(2017, 1, 3) }
            };
        }
        public IEnumerable<Dossier> GetAllDossier()
        {
            return _dossierList;
        }
    }
}
