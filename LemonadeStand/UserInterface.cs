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
				string input = Console.ReadLine();
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

		public static void DisplayGameInstructions()
		{
			Console.WriteLine("Welcome to Lemonade Stand, the game that lets you own a lemonade stand for 7 days!");
		}

		public static void DisplayCostMessage()
		{
			Console.WriteLine("Now we are going to determine how much you want to charge for each cup of lemonade. Remember: there are 10 cups in each pitcher.");
		}
    }
}
