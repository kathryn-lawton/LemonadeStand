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
        List<string> days = new List<string>() { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday"}; 

        //constructor
        public Day()
        {
            this.weather = new Weather();
        }



        //member methods (CAN DO)  
     

        public void MakeForecast()
        {
            for(int i = 0; i < days.Count; i++)
            {
                int dailyTemperature = weather.GetDailyTemperature();
                string dailyCondition = weather.GetDailyCondition();
                Console.WriteLine($"The weather on {days[i]} is {dailyTemperature} and {dailyCondition}.");
                Console.ReadLine();



            }
        }

  

        public void RunDay()
        {
            MakeForecast();
            weather.GetDailyWeather();
            weather.DisplayDailyWeather();



        }



    }
}
