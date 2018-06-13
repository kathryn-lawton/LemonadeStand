using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
     public class Cup : Item
    {
		public static double price = 0.01;

		public Cup() :
			base("cup")
        {
        }
    }
}
