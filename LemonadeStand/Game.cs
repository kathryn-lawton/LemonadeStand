using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Game
    {
        //member variables (HAS A)

        //constructor
        public Game()
        {
            
        }

        //member methods (CAN DO)
        
        public string GetPlayerName()
        {
            Console.WriteLine("Please enter your name: ");
            string playername = Console.ReadLine();
            return playername;
        }

        public void RunGame()
        {
            string playerName = GetPlayerName();
            Player player = new Player(playerName);

            

        }

    }
}
