﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Sugar : Item
    {
		public static double price = 0.20;

        public Sugar() :
			base("sugar")
        {
        }
    }
}
