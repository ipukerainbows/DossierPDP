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
            List<Drinks> mockDrinksList = new List<Drinks>()
            {
                new Drinks() { DrinkId = 1, DrinkName="Cola"},
                new Drinks() { DrinkId = 2, DrinkName="Jupilier"},
                new Drinks() { DrinkId = 3, DrinkName="Witte Wijn"},
                new Drinks() { DrinkId = 4, DrinkName="Rode Wijn"},
            };
            _dinerList = new List<Diner>()
            {
                new Diner(){DinerId = 1, DinerDrinksList = mockDrinksList, DinerMenuList = new List<Menu>()
                    {
                        new Menu()
                        {
                            MenuId=1,
                            MenuName = "Salade Geitenkaas",
                            MenuDescription = "Voorgerecht",
                            MenuIngredientsList = new List<Ingredients>()
                            {
                                new Ingredients()
                                {
                                    IngredientId = 1,
                                    IngredientName = "Sla"
                                },
                                new Ingredients()
                                {
                                    IngredientId = 2,
                                    IngredientName = "Geitenkaas"
                                }

                            }
                         },
                        new Menu()
                        {
                            MenuId=2,
                            MenuName = "Stoverij",
                            MenuDescription = "Hoofdgerecht",
                            MenuIngredientsList = new List<Ingredients>()
                            {
                                new Ingredients()
                                {
                                    IngredientId = 3,
                                    IngredientName = "Vlees"
                                },
                                new Ingredients()
                                {
                                    IngredientId = 4,
                                    IngredientName = "Groenten"
                                },
                                new Ingredients()
                                {
                                    IngredientId = 5,
                                    IngredientName = "Saus"
                                }
                            }
                        },
                        new Menu()
                        {
                            MenuId = 3,
                            MenuName = "Chocoladetaart",
                            MenuDescription = "Dessert",
                            MenuIngredientsList = new List<Ingredients>()
                            {
                                new Ingredients()
                                {
                                    IngredientId = 4,
                                    IngredientName = "Chocolade"
                                },
                                new Ingredients()
                                {
                                    IngredientId = 5,
                                    IngredientName = "Deeg"
                                }
                            }
                        }
                    }
                },
                new Diner()
                {
                    DinerId = 2,
                    DinerDrinksList = mockDrinksList,
                    DinerMenuList = new List<Menu>()
                    {
                        new Menu()
                        {
                            MenuId = 4,
                            MenuName = "Tomatensoep",
                            MenuDescription = "Voorgerecht",
                            MenuIngredientsList = new List<Ingredients>()
                            {
                                new Ingredients()
                                {
                                    IngredientId = 6,
                                    IngredientName = "Tomaat"
                                },
                                new Ingredients()
                                {
                                    IngredientId = 7,
                                    IngredientName = "Water"
                                }
                            }
                        },
                        new Menu()
                        {
                            MenuId = 5,
                            MenuName = "Gourmet Burger",
                            MenuDescription = "Hoofdgerecht",
                            MenuIngredientsList = new List<Ingredients>()
                            {
                                new Ingredients()
                                {
                                    IngredientId = 7,
                                    IngredientName="Groenten",
                                },
                                new Ingredients()
                                {
                                    IngredientId = 8,
                                    IngredientName = "Rundshamburger",
                                },
                                new Ingredients()
                                {
                                    IngredientId=9,
                                    IngredientName="Broodje"
                                }
                            }
                        },
                        new Menu()
                        {
                            MenuId = 5,
                            MenuName = "Appeltaart",
                            MenuDescription = "Dessert",
                            MenuIngredientsList = new List<Ingredients>()
                            {
                                new Ingredients()
                                {
                                    IngredientId = 10,
                                    IngredientName = "Appel"
                                },
                                new Ingredients()
                                {
                                    IngredientId = 11,
                                    IngredientName = "Taart"
                                }
                            }
                        }
                    }
                }
            };
        }

        public IEnumerable<Diner> GetAllDiner()
        {
            return _dinerList;
        }
    }
}
