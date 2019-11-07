using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DossierPDP.Models.repositories
{
    public interface IDinerRepository
    {
        IEnumerable<Diner> GetAllDiner();
    }
}
