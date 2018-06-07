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
        public double money = 20.00;
        List<Lemon> lemons = new List<Lemon>();
        List<Sugar> sugar = new List<Sugar>();
        List<Ice> ice = new List<Ice>();
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

        public void AddSugar(int NumberOfSugarNeeded)
        {
            for(int i = 0; i < NumberOfSugarNeeded; i++)
            {
                Sugar sugar = new Sugar();
                this.sugar.Add(sugar);
            }
            Console.WriteLine($"You currently have {sugar.Count} sugar.");
        }

        public void AddIce(int NumberOfIceNeeded)
        {
            for(int i = 0; i < NumberOfIceNeeded; i++)
            {
                Ice ice = new Ice();
                this.ice.Add(ice);
            }
            Console.WriteLine($"You currently have {ice.Count} ice.");
        }

        public void AddCup(int NumberOfCupsNeeded)
        {
            for(int i = 0; i < NumberOfCupsNeeded; i++)
            {
                Cup cup = new Cup();
                cups.Add(cup);
            }
            Console.WriteLine($"You currently have {cups.Count} cups.");
        }
        public void DisplayInventory()
        {
            
        }

 
    }
}
