using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public static class UserInterface
    {
        //member methods (CAN DO)
    

		public static string GetUserItem()
		{
			string itemName = string.Empty;
			do
			{
				Console.WriteLine("Please choose an item: 'lemon', 'sugar', 'ice', or 'cup'.");
				string input = Console.ReadLine().ToLower();
				switch (input)
				{
					case "lemon":
					case "sugar":
					case "ice":
					case "cup":
						itemName = input;
						break;
					default:
						Console.WriteLine("Please choose a valid input.");
						break;
				}
			} while (itemName == string.Empty);

			return itemName;
		}

		public static string GetUserYesOrNo(string prompt)
		{
			string response = string.Empty;
			
			Console.WriteLine(prompt);
			string input = Console.ReadLine().ToLower();
			if (input == "yes" || input == "no")
			{
				return input;
			}
			else
			{
				Console.WriteLine("Please enter valid input.");
				return GetUserYesOrNo(prompt);
			}
		}

		public static int GetUserPositiveNumber(string prompt)
		{
			int positiveNumber = 0;
			Console.WriteLine(prompt);
			try
			{
				positiveNumber = int.Parse(Console.ReadLine());
				if (positiveNumber > 0)
				{
					return positiveNumber;
				}
				else
				{
					Console.WriteLine("Please enter a number that is greater than 0.");
					return GetUserPositiveNumber(prompt);
				}
			}
			catch (Exception)
			{
				Console.WriteLine("Please enter a number that is greater than 0.");
				return GetUserPositiveNumber(prompt);
			}
		}

		public static void DisplayGameInstructions()
		{
			Console.WriteLine("Welcome to Lemonade Stand! Where you have 7 days to sell lemonade and make as much money as possible!\n" +
				"You’ll have complete control over your business, including pricing, quality control, inventory control, and purchasing\n" +
				"supplies. The first thing you’ll have to worry about is your recipe. At first, go with the default recipe,\n" +
				"but feel free to put your own twist on it.Make sure you buy enough of all your ingredients, or you won’t be able \n" +
				"to sell lemonade! The weather will also factor into whether or not customers decide to buy your lemonade.\n" +
				"Make sure you read the weather report every day! When the temperature drops, or the weather condition\n" + 
				"is less inviting (overcast, cloudy, rainy), don’t expect customers to buy nearly as much as they would \n" +
				"on a hot day that is sunny or hazy. Feel free to set your prices higher \n" +
				"on those hot, muggy days too, as you’ll make more profit, even if you sell less lemonade. \n" +
				"At the end of 7 days you’ll see how much money you made. Remember, with great lemonade comes great responsibility!\n");
		}

		public static double GetPricePerCup()
		{
			Console.WriteLine("How much would you like to charge per cup of lemonade? Please enter a price that is greater than $0.00." );
			try
			{
				double pricePerCup = Math.Round(double.Parse(Console.ReadLine()), 2);
				if (pricePerCup > 0)
				{
					return pricePerCup;
				}
				else 
				{
					Console.WriteLine("Please enter a price that is greater than $0.00.");
					return GetPricePerCup();
				}
			}
			catch (Exception)
			{
				Console.WriteLine("Please enter a price that is greater than $0.00.");
				return GetPricePerCup();
			}
		}

		public static void DisplayDailyProfit(double profit, int numberOfCupsSold)
		{
			Console.WriteLine($"Today you made ${profit} and sold {numberOfCupsSold} cups.");
		}

		public static void DisplayTotalProfit(double runningTotalProfit, int overallNumberOfCupsSold)
		{
			Console.WriteLine($"In your 7 days running a lemonande stand you made ${runningTotalProfit} and sold {overallNumberOfCupsSold} cups of lemonade.");
		}
	}
}
