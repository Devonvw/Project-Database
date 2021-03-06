using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomerenModel
{
    public class Drink
    {
        public int Id { get; set; } // StudentNumber, e.g. 474791
        public string Name { get; set; }

        public int Stock { get; set; }
        public double Price { get; set; }
        public int VatId { get; set; }
        public int AmountSold { get; set; }
        public Drink(int id, int vatId)
        {
            Id = id;
            VatId = vatId;
        }
        public Drink(int id, string name)
        {
            Id = id;
            Name = name;
        }
        public Drink(int id, string drinkName, int stock, double price, int vatId, int amountSold)
        {
            Id = id;
            Name = drinkName;
            Stock = stock;
            Price = price;
            VatId = vatId;
            AmountSold = amountSold;
        }
    }
}