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
        List<Sugar> sugar = new List<Sugar>();
        List<Ice> ice = new List<Ice>();
        List<Cup> cups = new List<Cup>();

        //constructor
        public Inventory()
        {

        }

        //member methods (CAN DO)
        public void AddLemons(int NumberOfLemonsNeeded)
        {
            for (int i = 0; i < NumberOfLemonsNeeded; i++)
            {
                Lemon lemon = new Lemon();
                lemons.Add(lemon);
            }
            Console.WriteLine($"You currently have {lemons.Count} lemons.");
        }
    }
}
