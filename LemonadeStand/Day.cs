﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Day
    {
		//member variables (HAS A)
		
		public string Name { get; set; }
		public string Condition { get; set; }
		public int Temperature { get; set; }
		public double Profit { get; set; }
		public int NumberOfCupsSold { get; set; }

		//constructor
		public Day(string name, Weather weather)
        {
			this.Name = name;
			this.Condition = weather.CreateDailyCondition();
			this.Temperature = weather.CreateDailyTemperature();
		}

        //member methods (CAN DO)  
		public void DisplayWeather()
		{
			Console.WriteLine($"{this.Name}'s weather is {this.Temperature} and {this.Condition}.");
		}

		public void SaveDay(double profit, int numberOfCupsSold)
		{
			this.Profit = profit;
			this.NumberOfCupsSold = numberOfCupsSold;
		}
	}
}
