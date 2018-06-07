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

        //constructor
        public Day()
        {
            this.weather = new Weather();
        }



        //member methods (CAN DO)  
        public void RunDay()
        {
          weather.DisplayDailyWeather();
        }



    }
}
