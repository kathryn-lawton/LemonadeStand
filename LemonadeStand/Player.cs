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

        //constructor
        public Player(string playerName)
        {
            this.Name = playerName;
            this.Inventory = new Inventory();
            this.Recipe = new Recipe();
        }

        //member methods (CAN DO)
    }
}
