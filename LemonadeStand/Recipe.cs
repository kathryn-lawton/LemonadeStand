using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Recipe
    {
		//mv
		Inventory inventory;
		public int numberOfPitchers;
		public int lemonsToRemoveFromInventory;
		public int iceToRemoveFromInventory;
		public int sugarToRemoveFromInventory;
		public int cupsToRemoveFromInventory;
		public int lemonsForRecipe = 2;
		public int iceForRecipe = 10;
		public int sugarForRecipe = 2;
		public int cupsForRecipe = 10;


        public Recipe(Inventory inventory)
        {
			this.inventory = inventory;
        }

        //mm
		public void DecideRecipe()
		{
			Console.WriteLine($"We start you off with a default recipe. This recipe contains {lemonsForRecipe} lemons, {sugarForRecipe} sugar, and {iceForRecipe} ice. Would you like to use the default recipe or create a custom recipe? Please enter 'default' or 'custom'");
			string input = Console.ReadLine();
			if(input == "custom")
			{
				
			}
			else if(input == "default")
			{
				CreateCustomRecipeLemons();
			}
			else
			{
				Console.WriteLine("Your input was invalid. Please enter a valid response.");
			}
		}

		public int ChooseNumberOfPitchers()
		{
			Console.WriteLine($"Please choose how many pitchers of lemonade you would you like to make for the day. Each pitcher contains {cupsForRecipe} cups of lemonade.");
			Console.WriteLine("There are several things that influence how much lemonade you will sell.");
			Console.WriteLine("If the weather is warm and/or sunny you will sell more lemonade. You cannot use leftover lemonade from the day before.");
			Console.WriteLine("How many pitchers would you like to make? Please enter a number.");
			try
			{
				int numberOfPitchers = int.Parse(Console.ReadLine());
				return this.numberOfPitchers;
			}
			catch(Exception)
			{
				Console.WriteLine("Please enter a valid number.");
				ChooseNumberOfPitchers();
				throw;
			}
		}

		public int CreateCustomRecipeLemons()
		{
			Console.WriteLine("Let's create your custom recipe. How many lemons would you like to use? Please enter a number.");
			try
			{
				int lemonsForRecipe = int.Parse(Console.ReadLine());
				return this.lemonsForRecipe;
			}
			catch(Exception)
			{
				Console.WriteLine("Please enter a valid number.");
				CreateCustomRecipeLemons();
				throw;
			}
			
		}

		public int CreateCustomRecipeSugar()
		{
			Console.WriteLine("Let'How much sugar would you like to use in your recipe? Please enter a number.");
			try
			{
				int sugarForRecipe = int.Parse(Console.ReadLine());
				return this.sugarForRecipe;
			}
			catch (Exception)
			{
				Console.WriteLine("Please enter a valid number.");
				CreateCustomRecipeSugar();
				throw;
			}

		}

		public int CreateCustomRecipeIce()
		{
			Console.WriteLine("How much ice would you like to use is your recipe? Please enter a number.");
			try
			{
				int iceForRecipe = int.Parse(Console.ReadLine());
				return this.iceForRecipe;
			}
			catch (Exception)
			{
				Console.WriteLine("Please enter a valid number.");
				CreateCustomRecipeIce();
				throw;
			}

		}

		public void DisplayCustomRecipe()
		{
			Console.WriteLine($"Your custom recipe includes {this.lemonsForRecipe} lemons, {this.sugarForRecipe} sugar, and {this.iceForRecipe} ice. This will make {cupsForRecipe} cups of lemonade.");
		}


		public int RemoveLemonsFromRecipe()
		{
			try
			{
				lemonsToRemoveFromInventory = numberOfPitchers * lemonsForRecipe;
				return lemonsToRemoveFromInventory;
			}
			catch (Exception)
			{
				Console.WriteLine("You don't have enough lemons! Let's choose a new recipe!");
				DecideRecipe();
				throw;
			}
		}

		public int RemoveSugarFromRecipe()
		{
			try
			{
				sugarToRemoveFromInventory = numberOfPitchers * sugarForRecipe;
				return sugarToRemoveFromInventory;
			}
			catch (Exception)
			{
				Console.WriteLine("You don't have enough sugar! Let's choose a new recipe!");
				DecideRecipe();
				throw;
			}
		}

		public int RemoveIceFromRecipe()
		{
			try
			{
				iceToRemoveFromInventory = numberOfPitchers * iceForRecipe;
				return iceToRemoveFromInventory;
			}
			catch (Exception)
			{
				Console.WriteLine("You don't have enough ice! Let's choose a new recipe!");
				DecideRecipe();
				throw;
			}
		}

		public int RemoveCupsFromRecipe()
		{
			try
			{
				cupsToRemoveFromInventory = numberOfPitchers * cupsForRecipe;
				return cupsToRemoveFromInventory;
			}
			catch(Exception)
			{
				Console.WriteLine($"You don't have enough cups for the recipe.");
				DecideRecipe();
				throw;
			}
		}


	}
}
