using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Day
    {
		//member variables (HAS A)
		//customers
		//eather
		//report (profit/loss, remaining inventory)
		public string Name { get; set; }
		public string Condition { get; set; }
		public int Temperature { get; set; }
		public int PitchersProduced { get; set; }
		public List<Customer> customers;

		//constructor
		public Day(string name, Weather weather)
        {
			this.Name = name;
			this.Condition = weather.CreateDailyCondition();
			this.Temperature = weather.CreateDailyTemperature();
			this.customers = new List<Customer> { new Customer() };
        }

        //member methods (CAN DO)  
		public int CreateCustomers()
		{
			Random random = new Random();
			int numberOfDayCustomers = random.Next(50, 100);
				return numberOfDayCustomers;
			
		}

		public void RunDay()
        {
			CreateCustomers();
        }

		public void DisplayWeather()
		{
			Console.WriteLine($"{this.Name}'s weather is {this.Temperature} and {this.Condition}.");
		}
	}
}
