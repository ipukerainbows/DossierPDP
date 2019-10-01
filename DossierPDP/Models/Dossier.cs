using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DossierPDP.Models
{
    public class Dossier
    {
        public int DossierId { get; set; }
        public string DossierName { get; set; }
        public List<Organiser> OrganiserList{ get; set; }
        public int CustomerId { get; set; }
        public PartyType PartyType { get; set; }
        public DateTime DatePlanned { get; set; }
        public int Budget { get; set; }
        public Room Room { get; set; }

        public List<>  { get; set; }
    }
}
