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
        //welcome player
        //print instructions

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
			Console.WriteLine("Welcome to Lemonade Stand, the game that lets you own a lemonade stand for 7 days!");
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
