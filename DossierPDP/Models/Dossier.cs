using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DossierPDP.Models
{
    public class Dossier
    {
        public int IdDossier { get; set; }
        public int CustomerID { get; set; }
        public string Name { get; set; }
        public PartyType PartyType { get; set; }
        public DateTime DatePlanned { get; set; }
        public int Budget { get; set; }
        public Room Room { get; set; }

    }
}
