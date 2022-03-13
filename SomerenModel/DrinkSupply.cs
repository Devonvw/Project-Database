using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomerenModel
{
    public class DrinkSupply
    {
        public string DrinkName { get; set; }
        public int Stock { get; set; }
        public double Price { get; set; }
        public int AmountSold { get; set; }

        public DrinkSupply(string drinkName, int stock, double price, int amountSold)
        {
            DrinkName = drinkName;
            Stock = stock;
            Price = price;
            AmountSold = amountSold;
        }
    }

}
