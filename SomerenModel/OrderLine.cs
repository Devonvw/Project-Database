using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomerenModel
{
    public  class OrderLine
    {
        public int Amount { get; set; }
        public Drink Drink { get; set; }

        public OrderLine(int amount, Drink drink)
        {
            this.Amount = amount;
            this.Drink = drink;
        }
    }
}
