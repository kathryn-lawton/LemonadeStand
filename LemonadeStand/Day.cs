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
        public Weather weather;
        //public List<string> days = new List<string>() { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday"};
		public string name;

		//constructor
		public Day(string name)
        {
            this.weather = new Weather();
			this.name = name;
        }



        //member methods (CAN DO)  
     

        public void MakeForecast(List <Day> days)
        {
            for(int i = 0; i < days.Count; i++)
            {
                int dailyTemperature = weather.GetDailyTemperature();
                string dailyCondition = weather.GetDailyCondition();
                Console.WriteLine($"Weekly Forecast: The weather on {days[i].name} is {dailyTemperature} and {dailyCondition}.");
                Console.ReadLine();



            }
		}

		


		public void RunDay(List <Day> days)
        {

			Console.WriteLine($"Today is {days[0].name}!");
			weather.GetDailyWeather();
			weather.DisplayDailyWeather();
			
			


        }



    }
}
