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
		public void DecideIfBuyingItems()
		{
				string prompt = $"You currently have ${Money}. Do you want to purchase any items? Please select 'yes' or 'no'.";
				string response = UserInterface.GetUserYesOrNo(prompt);
				if (response == "yes")
				{
					string item = UserInterface.GetUserItem();
					BuyItem(item);
				}
		}

		public void BuyItem(string itemName)
		{
			string prompt = $"How many items would you like to purchase? Please enter a number greater than or equal to 0.";
			int numberOfItems = UserInterface.GetUserPositiveNumber(prompt);

			double price = 0;
			List<Item> items = new List<Item>();
			for(int i = 0; i < numberOfItems; ++i)
			{
				switch (itemName)
				{
					case "lemon":
						price = Lemon.price;
						items.Add(new Lemon());
						break;
					case "sugar":
						price = Sugar.price;
						items.Add(new Sugar());
						break;
					case "ice":
						price = Ice.price;
						items.Add(new Ice());
						break;
					case "cup":
						price = Cup.price;
						items.Add(new Cup());
						break;
				}
			}

			if(price * numberOfItems > Money)
			{
				Console.WriteLine($"You do not have enough money to buy {numberOfItems} {itemName}. It costs ${price * numberOfItems} and you have ${Money}.");
			}
			else
			{
				Money -= price * numberOfItems;
				Console.WriteLine($"You have ${Money} after your purchase.");

				Inventory.AddItems(items); 
			}

			DecideIfBuyingItems();
		}

		public bool MakeAPitcher()
		{
			if (Recipe.numberOfLemons <= Inventory.lemons.Count
				&& Recipe.numberOfIce <= Inventory.ice.Count
				&& Recipe.numberOfSugar <= Inventory.sugar.Count
				&& Inventory.cups.Count > 0)
			{
				Inventory.RemoveItems("lemon", Recipe.numberOfLemons);
				Inventory.RemoveItems("sugar", Recipe.numberOfSugar);
				Inventory.RemoveItems("ice", Recipe.numberOfIce);

				return true;
			}
			else
			{
				return false;
			}
		}
	}
}
