using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Player
    {
        //member variables (HAS A)
        public string name;
        public int money;
        public Inventory inventory = new Inventory();

        //constructor
        public Player(string playerName)
        {
            this.name = playerName;
            this.money = 20;
        }

        //member methods (CAN DO)
    }
}
