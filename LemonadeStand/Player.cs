using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Player
    {
        //member variables (HAS A)
        public string Name { get; set; }
        public Inventory Inventory { get; set; }
        public Recipe Recipe { get; set; }
		public double Money { get; set; }

		//constructor
		public Player(string playerName)
        {
            this.Name = playerName;
            this.Inventory = new Inventory();
            this.Recipe = new Recipe();
			this.Money = 20.00;
        }

		//member methods (CAN DO)
		public void DecidePurchases()
			
		{
			bool isValid = false;
			do
			{
				Console.WriteLine($"You currently have ${Money}. Would you like to purchase any items? 'yes' or 'no'.");
				string input = Console.ReadLine();
				if (input == "yes")
				{
					PurchaseItems();
					isValid = true;
				}
				else if (input == "no")
				{
					isValid = true;
				}
				else
				{
					Console.WriteLine("Please enter valid input.");
				}
				
			} while (!isValid);
		}

		private void PurchaseItems()
		{
			bool isValid = false;
			do
			{
				string input = UserInterface.GetUserItem();
				switch (input)
				{
					case "lemon":
					case "sugar":
					case "ice":
					case "cup":
						isValid = true;
						BuyItem(input);
						break;
					default:
						isValid = false;
						Console.WriteLine("Please choose a valid input.");
						break;
				}
			} while (!isValid);
		}

		//loop to buy additional items

		public void BuyItem(string itemName)
		{
			// TODO, Add logic for money - how much money player has to spend
			bool isValidPurchase = false;
			do
			{
				try
				{
					Console.WriteLine($"How many items would you like to purchase? Please enter a number greater than or equal to 0.");
					int numberOfItems = int.Parse(Console.ReadLine());

					List<Item> items = new List<Item>();
					for(int i = 0; i < numberOfItems; ++i)
					{
						switch (itemName)
						{
							case "lemon":
								items.Add(new Lemon());
								break;
							case "sugar":
								items.Add(new Sugar());
								break;
							case "ice":
								items.Add(new Ice());
								break;
							case "cup":
								items.Add(new Cup());
								break;
							default:
								break;
						}
					}

					if(items.Count > 0)
					{
						// TODO, check money method
						if(items[0].Price * numberOfItems > Money)
						{
							isValidPurchase = false;
							Console.WriteLine($"You do not have enough money to buy {numberOfItems} {itemName}. It costs {items[0].Price * numberOfItems} and you have {Money}");
						}
						else
						{
							Money -= items[0].Price * numberOfItems;
							Console.WriteLine($"You have ${Money} after your purchase.");

							Inventory.AddItems(items); // Say the updated items
							isValidPurchase = true;
						}
					}
					else if(items.Count == 0 && numberOfItems == 0)
					{
						isValidPurchase = true;
					}
				}
				catch (Exception)
				{
					Console.WriteLine("Please enter a valid number.");
				}

			} while (!isValidPurchase);

			Console.WriteLine($"Your purchase was successful");

			Console.WriteLine("Would you like to purchase additional items? Please enter 'yes' or 'no'.");
			string input = Console.ReadLine();
			if(input == "yes")
			{
				PurchaseItems();
			}
			else if (input == "no")
			{

			}
			else
			{
				Console.WriteLine("Please enter valid input.");
			}
		}

		//public void DeterminePricePerCup()
		//{
			//Console.WriteLine($"The current price per cup of lemonade is ${}. Would you like to change the price? Please enter 'yes' or 'no'.");
			//string input = Console.ReadLine().ToLower();
			//if (input == "yes")
			//{

				//Console.WriteLine($"Today's price per cup of lemonade is ${this.pricePerCup}.");
			//}
			//else if (input == "no")
			//{
				//Console.WriteLine($"Today's price per cup of lemonade is ${this.pricePerCup}.");
			//}
			//else
			//{
				//Console.WriteLine("Your input was invalid. Please enter valid input.");
			//}
		//}

		//public double ChangePricePerCup()
		//{
			//double pricePerCup = 0.0;
			//Console.WriteLine("How much would you like to charge per cup of lemonade. Please enter a number that is more than 0.");
			//pricePerCup = double.Parse(Console.ReadLine());
			//return pricePerCup;
		
		//}

	}
}
