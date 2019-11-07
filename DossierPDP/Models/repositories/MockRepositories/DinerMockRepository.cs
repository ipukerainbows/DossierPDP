using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DossierPDP.Models.repositories
{
    public class DinerMockRepository : IDinerRepository
    {
        private List<Diner> _dinerList;
        public DinerMockRepository()
        {
            _dinerList = new List<Diner>()
            {
              
            };
        }

        public IEnumerable<Diner> GetAllDiner()
        {
            throw new NotImplementedException();
        }
    }
}
