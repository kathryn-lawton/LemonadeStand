﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Ice : Item
    {
		public static double price = 0.02;

        public Ice() :
			base("ice")
        {   
        }
    }
}
