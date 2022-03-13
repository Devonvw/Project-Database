using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SomerenDAL;
using SomerenModel;

namespace SomerenLogic
{
    public class DrinkSupplyService
    {
        DrinkSupplyDao drinkSupplydb;

        public DrinkSupplyService()
        {
            drinkSupplydb = new DrinkSupplyDao();
        }
        public List<DrinkSupply> GetDrinksSupplies()
        {
            List<DrinkSupply> drinkksSupplies = drinkSupplydb.GetAllDrinkSupplies();
            return drinkksSupplies;
        }
    }

}
