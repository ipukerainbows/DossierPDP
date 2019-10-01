using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DossierPDP.Models
{
    public class Diner
    {
        public int DinerId { get; set; }
        public List<Menu> DinerMenuList { get; set; }
        public List<Drinks> DinerDrinksList { get; set; }

    }
}
