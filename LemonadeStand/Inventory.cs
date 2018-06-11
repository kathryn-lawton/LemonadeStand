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
        List<Lemon> lemons = new List<Lemon>();
        List<Ice> ice = new List<Ice>();
        List<Sugar> sugar = new List<Sugar>();
        List<Cup> cups = new List<Cup>();

        //constructor
        public Inventory()
        {
        }

		public void AddItems(List<Item> items)
		{
			
			foreach (Item item in items)
			{
				switch(item.Name)
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
					case "cups":
						cups.Add((Cup)item);
						break;
					default:
						break;

				}
			}
			Console.WriteLine($"You have increased your {items[0].Name} inventory by {items.Count}.");
		}

       //TODO remove method 
        public void RemoveItems(List <Item> items)
        {
			foreach (Item item in items)
			{
				switch (item.Name)
				{
					case "lemon":
						for (int i = 0; i < items.Count; i++)
						{
							lemons.RemoveAt(0);
						}
;						break;
					case "sugar":
						sugar.RemoveAt(0);
						for(int i = 0; i < items.Count; i++)
						{
							sugar.RemoveAt(0);
						}
						break;
					case "ice":
						
						for(int i = 0; i < items.Count; i++)
						{
							ice.RemoveAt(0);
						}
						break;
					case "cups":
						for(int i = 0; i < items.Count; i++)
						{
							cups.RemoveAt(0);
						}
						break;
					default:
						break;

				}
			}


			//return bool if the remove was successful or false if the remove failed (i.e. only 5 items but want to remove 5)
		}

        public void DisplayInventory()
        {
            Console.WriteLine($"You currently have {lemons.Count} lemons, {sugar.Count} sugar, {ice.Count} ice, and {cups.Count} cups.");
        }
    }
}
