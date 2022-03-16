using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomerenModel
{
    public class Drink
    {
        public int DrinkId { get; set; }
        public string DrinkName { get; set; }
        public int Stock { get; set; }
        public double Price { get; set; }
        public int VatId { get; set; }
        public int AmountSold { get; set; }

        public Drink(string drinkName, int stock, double price, int vatId, int amountSold)
        {
            DrinkName = drinkName;
            Stock = stock;
            Price = price;
            VatId = vatId;
            AmountSold = amountSold;
        }
    }
}
