using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public abstract class Item
    {
        //member variables
        public string Name { get; set; }
        public double Price { get; set; }

        public Item(string name, double price)
        {
			this.Name = name;
			this.Price = price;
        }
        //member methods
    }
}
