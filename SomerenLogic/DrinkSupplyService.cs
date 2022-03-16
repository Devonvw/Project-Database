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
        public void AddDrinkSupply(DrinkSupply drink)
        {
            drinkSupplydb.AddDrinkSupply(drink);
        }
        public void UpdateDrinkSupply(DrinkSupply drink)
        {
            drinkSupplydb.UpdateDrinkSupply(drink);
        }
        public void DeleteDrinkSupply(DrinkSupply drink)
        {
            drinkSupplydb.DeleteDrinkSupply(drink);
        }
        public int GenerateId()
        {
            return drinkSupplydb.GenerateId();
        }
    }
}
