using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomerenModel
{
    public class DrinkSupply
    {
        public int DrinkId { get; set; }
        public string DrinkName { get; set; }
        public int Stock { get; set; }
        public double Price { get; set; }
        public int VatId { get; set; }
        public int AmountSold { get; set; }

<<<<<<< HEAD:SomerenModel/Drink.cs
        public Drink(int id, string name, int stock, double price, int vatId, int amountSold)
=======
        public DrinkSupply(int drinkId, string drinkName, int stock, double price, int vatId, int amountSold)
>>>>>>> 8128bf4e97699f0d229ca20c6b923a0a53bc39b7:SomerenModel/DrinkSupply.cs
        {
            DrinkId = drinkId;
            DrinkName = drinkName;
            Stock = stock;
            Price = price;
            VatId = vatId;
            AmountSold = amountSold;
        }
    }

}
