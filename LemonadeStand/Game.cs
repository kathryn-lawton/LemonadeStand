using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Game
    {
        
        public Player player;
		public List<Day> days = new List<Day>();
		public Weather weather;

		private List<string> daysOfTheWeek = new List<string> { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

	
        //constructor
        public Game()
        {
			this.weather = new Weather();
			
			// Create a week
			foreach(string dayName in daysOfTheWeek)
			{
				days.Add(new Day(dayName, this.weather));
			} 
        }

        //member methods (CAN DO)
        
        public string GetPlayerName()
        {
            Console.WriteLine("Please enter your name: ");
            string playername = Console.ReadLine();
            return playername;
        }

		public void GetWeatherForecast()
		{
			Console.WriteLine("This week's weather forecast is...");
			
			foreach(Day day in days)
			{
				day.DisplayWeather();
			}
		}

		public void RunGame()
		{
			// Create Player
			string playerName = GetPlayerName();
			player = new Player(playerName);

			// Forecast
			GetWeatherForecast();

			foreach (Day day in days)
			{
				Console.WriteLine($"Today is {day.Name}.");
				day.DisplayWeather();
				player.Recipe.DecideRecipe();
				player.Inventory.DisplayInventory();
				player.DecidePurchases();
				day.CreateCustomers();

				
			}
		}
    }
}
