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

        //member methods (CAN DO)
        public void AddLemons(int numberOfLemonsToAdd)
        {
            for(int i = 0; i < numberOfLemonsToAdd; i++)
            {
                Lemon lemon = new Lemon();
                lemons.Add(lemon);
            }
            Console.WriteLine($"You currently have {lemons.Count} lemons after {numberOfLemonsToAdd} were added.");

		}

        public void RemoveLemons(int numberOfLemonsToRemove)
        {
			if(numberOfLemonsToRemove > this.lemons.Count)
			{
				Console.WriteLine($"You only have {this.lemons.Count} lemons. You cannot remove {numberOfLemonsToRemove} lemons.");
				// TODO, return something here
			}
			else
			{
				this.lemons.RemoveRange(0, numberOfLemonsToRemove);
				Console.WriteLine($"You now have {this.lemons.Count} after removing {numberOfLemonsToRemove}.");
			}
        }

        public void DisplayInventory()
        {
            Console.WriteLine($"You currently have {lemons.Count} lemons, {sugar.Count} sugar, {ice.Count} ice, and {cups.Count} cups.");
        }
    }
}
