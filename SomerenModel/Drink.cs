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
        public float Price { get; set; }
        public int VatId { get; set; }
        public int AmountSold { get; set; }

        public Drink(int id, string name, int stock, float price, int vatId, int amountSold)
        {
            Id = id;
            Name = name;
            Stock = stock;
            Price = price;
            VatId = vatId;
            AmountSold = amountSold;
        }
    }
}
