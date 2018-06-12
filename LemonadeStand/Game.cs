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

			double runningTotalProfit = 0;
			int overallNumberOfCupsSold = 0;
			foreach (Day day in days)
			{
				Console.WriteLine($"Today is {day.Name}.");
				day.DisplayWeather();
				player.Recipe.DecideRecipe();
				player.Inventory.DisplayInventory();
				player.DecideIfBuyingItems();
				
				RunDay(day);

				runningTotalProfit += day.Profit;
				overallNumberOfCupsSold += day.NumberOfCupsSold;

				UserInterface.DisplayDailyProfit(day.Profit, day.NumberOfCupsSold);
			}

			UserInterface.DisplayTotalProfit(runningTotalProfit, overallNumberOfCupsSold);
			Console.ReadLine();
		}

		private void RunDay(Day day)
		{
			double pricePerCup = UserInterface.GetPricePerCup();
			List<Customer> customers = CreateCustomers();

			int numberOfPitchersMade = 0;
			bool haveAPitcher = player.MakeAPitcher();

			if(haveAPitcher)
			{
				numberOfPitchersMade += 1;
			}

			int remainingCupsInPitcher = 10;
			int numberOfCupsSold = 0;
			if(haveAPitcher)
			{ 
				for(int  i = 0; i < customers.Count; i++)
				{
					bool boughtLemonade = customers[i].ChanceToBuy(day, pricePerCup, i);
					if(boughtLemonade)
					{
						player.Inventory.RemoveItems("cup", 1);
						numberOfCupsSold += 1;

						remainingCupsInPitcher -= 1;
						if(remainingCupsInPitcher == 0)
						{
							haveAPitcher = player.MakeAPitcher();
							if(haveAPitcher)
							{
								numberOfPitchersMade += 1;
								remainingCupsInPitcher = 10;
							}
						}
					}

					if(!haveAPitcher || player.Inventory.cups.Count == 0)
					{
						Console.WriteLine("You are SOLD OUT for today! You ran out of at least one item.");
						player.Inventory.DisplayInventory();
						break;
					}
				}
			}

			double loss = numberOfPitchersMade * player.Recipe.PriceOfPitcher() + numberOfCupsSold * Cup.price;
			double revenue = numberOfCupsSold * pricePerCup;
			player.Money += revenue - loss;
			day.SaveDay(revenue - loss, numberOfCupsSold);
		}

		private List<Customer> CreateCustomers()
		{
			Random random = new Random();
			int numberOfDayCustomers = random.Next(50, 100);

			List<Customer> customers = new List<Customer>();
			for (int i = 0; i < numberOfDayCustomers; i++)
			{
				customers.Add(new Customer());
			}

			return customers;
		}		
	}
}
