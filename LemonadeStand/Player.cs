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
        public string name;
        public Inventory inventory;
        public Recipe recipe;

        //constructor
        public Player(string playerName)
        {
            this.name = playerName;
            inventory = new Inventory();
            recipe = new Recipe();

        }

        //member methods (CAN DO)
    }
}
