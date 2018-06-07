using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Weather
    {
        //member variables (HAS A)
        public List<string> conditions = new List<string>() { "sunny", "hazy", "cloudy", "overcast", "rainy" };
        public int dailyTemperature;
        public string dailyCondition;
       

        //constructor
        public Weather()
        {

        }

        //member methods (CAN DO)

        public string GetDailyCondition()
        {
            Random random = new Random();
            int index = random.Next(conditions.Count);
            string condition = conditions[index];
                return condition;

        }
        public int GetDailyTemperature()
        {
            Random random = new Random();
            int dailyTemperature = random.Next(50,100);
            return dailyTemperature;
        }
        
        public void GetDailyWeather()
        {
            
        }

        public void DisplayDailyWeather()
        {
            dailyTemperature = GetDailyTemperature();
            dailyCondition = GetDailyCondition();

            Console.WriteLine($"Today's weather is {dailyTemperature} and {dailyCondition}.");
            Console.ReadLine();
        }

        public void GetForecastCondition()
        {

        }

        public void GetForecastTemperature()
        {

        }

        public void CreateForecast()
        {
     
        }
    }
}
