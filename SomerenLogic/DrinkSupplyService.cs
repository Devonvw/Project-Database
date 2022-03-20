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
        DrinkDao drinkSupplydb;

        public DrinkSupplyService()
        {
            drinkSupplydb = new DrinkDao();
        }
        public List<Drink> GetDrinksSupplies()
        {
            List<Drink> drinkksSupplies = drinkSupplydb.GetAllDrinkSupplies();
            return drinkksSupplies;
        }
        public void AddDrinkSupply(Drink drink)
        {
            drinkSupplydb.AddDrinkSupply(drink);
        }
        public void UpdateDrinkSupply(Drink drink)
        {
            drinkSupplydb.UpdateDrinkSupply(drink);
        }
        public void DeleteDrinkSupply(Drink drink)
        {
            drinkSupplydb.DeleteDrinkSupply(drink);
        }
    }
}
