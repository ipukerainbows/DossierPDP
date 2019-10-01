using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DossierPDP.Models
{
    public class Dossier
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CustomerID { get; set; }
        public PartyType PartyType { get; set; }

        public override string ToString()
        {
            return "Dossier : " + Id + " " + Name + " Customer : " + CustomerID + " " + PartyType;
        }
    }
}
