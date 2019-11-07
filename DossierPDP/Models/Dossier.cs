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
        public int CustomerId { get; set; }
        public PartyType? PartyType { get; set; }
        public DateTime DatePlanned { get; set; }
        public int Budget { get; set; }


        public List<Room> DossierRoomList { get; set; }
        public List<Organiser> DossierOrganisersList { get; set; }
        public List<Reception> DossierReceptionsList { get; set; }
        public List<Diner> DossierDinersList  { get; set; }
        public List<Reception> DossierRemarksList { get; set; }

    }
}
