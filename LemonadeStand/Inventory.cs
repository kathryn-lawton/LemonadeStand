using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Inventory
    {
		//member variables (HAS A)
		public List<Lemon> lemons = new List<Lemon>();
        public List<Ice> ice = new List<Ice>();
        public List<Sugar> sugar = new List<Sugar>();
        public List<Cup> cups = new List<Cup>();

        //constructor
        public Inventory()
        {
        }

		public void AddItems(List<Item> items)
		{
			foreach(Item item in items)
			{
				switch (item.Name)
				{
					case "lemon":
						lemons.Add((Lemon)item);
						break;
					case "sugar":
						sugar.Add((Sugar)item);
						break;
					case "ice":
						ice.Add((Ice)item);
						break;
					case "cup":
						cups.Add((Cup)item);
						break;
				}
			}

			Console.WriteLine($"You have increased your {items[0].Name} inventory by {items.Count}.");
			DisplayInventory();
		}

        public void RemoveItems(string itemName, int numberOfItems)
        {
			switch(itemName)
			{
				case "lemon":
					lemons.RemoveRange(0, numberOfItems);
					break;
				case "sugar":
					sugar.RemoveRange(0, numberOfItems);
					break;
				case "ice":
					ice.RemoveRange(0, numberOfItems);
					break;
				case "cup":
					cups.RemoveRange(0, numberOfItems);
					break;
			}
		}

        public void DisplayInventory()
        {
            Console.WriteLine($"You currently have {lemons.Count} lemons, {sugar.Count} sugar, {ice.Count} ice, and {cups.Count} cups.");
        }
    }
}
