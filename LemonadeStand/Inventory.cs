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

        public void AddLemon(int NumberOfLemonsNeeded)
        {
            for(int i = 0; i < NumberOfLemonsNeeded; i++)
            {
                Lemon lemon = new Lemon();
                lemons.Add(lemon);
            }
            Console.WriteLine($"You currently have {lemons.Count} lemons.");
        }

        public void RemoveLemon(Player player)
        {
            try
            {
				int lemonsToRemove = player.recipe.RemoveLemonsFromRecipe();
				for(int i = 0; i < lemonsToRemove; i++)
				{
					lemons.RemoveAt(0);
				}
            }

            catch(Exception)
            {

            }
        }

        public void AddSugar(int NumberOfSugarNeeded)
        {
            for (int i = 0; i < NumberOfSugarNeeded; i++)
            {
                Sugar sugar = new Sugar();
                this.sugar.Add(sugar);
            }
            Console.WriteLine($"You currently have {sugar.Count} sugar.");
        }

		public void RemoveSugar(Player player)
		{
			try
			{
				int sugarToRemove = player.recipe.RemoveSugarFromRecipe();
				for (int i = 0; i < sugarToRemove; i++)
				{
					sugar.RemoveAt(0);
				}
			}

			catch (Exception)
			{

			}
		}

		public void AddIce(int NumberOfIceNeeded)
        {
            for (int i = 0; i < NumberOfIceNeeded; i++)
            {
                Ice ice = new Ice();
                this.ice.Add(ice);
            }
            Console.WriteLine($"You currently have {ice.Count} ice.");
        }

		public void RemoveIce(Player player)
		{
			try
			{
				int iceToRemove = player.recipe.RemoveIceFromRecipe();
				for (int i = 0; i < iceToRemove; i++)
				{
					ice.RemoveAt(0);
				}
			}

			catch (Exception)
			{

			}
		}

		public void AddCup(int NumberOfCupsNeeded)
        {
            for (int i = 0; i < NumberOfCupsNeeded; i++)
            {
                Cup cup = new Cup();
                cups.Add(cup);
            }
            Console.WriteLine($"You currently have {cups.Count} cups.");
        }

        public void DisplayInventory()
        {
            Console.WriteLine($"You currently have {lemons.Count} lemons, {sugar.Count} sugar, {ice.Count} ice, and {cups.Count} cups.");
        }

		public void RemoveCups(Player player)
		{
			try
			{
				int cupsToRemove = player.recipe.RemoveCupsFromRecipe();
				for (int i = 0; i < cupsToRemove; i++)
				{
					ice.RemoveAt(0);
				}
			}
			catch (Exception)
			{
				Console.WriteLine("");
			}

			
		}


		//removes after lemonade made
		public void RemoveInventoryAfterMakingLemonade(Player player)
		{
			RemoveLemon(player);
			RemoveSugar(player);
			RemoveIce(player);
		}
 
    }
}
