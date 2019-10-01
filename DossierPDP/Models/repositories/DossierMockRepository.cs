using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DossierPDP.Models.repositories
{
    public class DossierMockRepository 
    {
        private List<Dossier> _dossierList;
        public DossierMockRepository()
        {
            _dossierList = new List<Dossier>()
            {
                new Dossier() { DossierId = 1, DossierName = "Dossier 1" , CustomerId = 1, PartyType = PartyType.optie1}
            };
        }
    }
}
