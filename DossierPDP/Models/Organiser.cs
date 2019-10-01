using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DossierPDP.Models
{
    public class Organiser
    {
        public int OrganiserId { get; set; }
        public string OrganiserFirstName { get; set; }
        public string OrganiserLastName { get; set; }
        public string OrganiserAddress { get; set; }
        public string OrganiserTelephoneNumber { get; set; }
        public string FirstContact { get; set; }
        public string OrganiserEmailAddress { get; set; }
    }
}
