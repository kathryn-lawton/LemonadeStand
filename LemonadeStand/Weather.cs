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
		private Random Random { get; set; }

		//constructor
		public Weather()
        {
			this.Random = new Random();
        }

        //member methods (CAN DO)

        public string CreateDailyCondition()
        {
            int index = this.Random.Next(conditions.Count);
            string condition = conditions[index];

			return condition;
		}

        public int CreateDailyTemperature()
        {
            int dailyTemperature = this.Random.Next(50,100);

            return dailyTemperature;
        }
    }
}
