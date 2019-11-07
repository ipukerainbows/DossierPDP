using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DossierPDP.Models.repositories
{
    public class ReceptionMockRepository : IReceptionsRepository
    {
        private List<Reception> _receptionList;

        public ReceptionMockRepository()
        {
            _receptionList = new List<Reception>()
            {
                new Reception() {}
            };
        }

        public IEnumerable<Reception> GetReceptions()
        {
            return _receptionList; 
        }
    }
}
