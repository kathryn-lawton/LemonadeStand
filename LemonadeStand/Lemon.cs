using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Lemon : Item
    {
		//member variables
		public static double price = 0.05;

        public Lemon() : 
			base("lemon")
        {
        }
        //member methods
    }
}
