using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DossierPDP.Models.repositories
{
    public class OrganiserMockRepository : IOrganiserList
    {
        private List<Organiser> _organiserList;
        public OrganiserMockRepository()
        {
            _organiserList = new List<Organiser>()
            {
                new Organiser() { OrganiserId = 1, OrganiserFirstName = "Nick", OrganiserLastName ="Foulon", OrganiserAddress="Noordstraat 2 c", OrganiserTelephoneNumber="0470511500", FirstContact ="Website", OrganiserEmailAddress ="foulonnick@gmail.com" },
                new Organiser() { OrganiserId = 1, OrganiserFirstName = "Raf", OrganiserLastName ="Gillisjans", OrganiserAddress="bxl", OrganiserTelephoneNumber="0470693939", FirstContact ="Website", OrganiserEmailAddress ="rafgillisjansk@gmail.com" }
            };
        }

        public IEnumerable<Organiser> GetAllOrganisers()
        {
            return _organiserList;
        }
    }
}
