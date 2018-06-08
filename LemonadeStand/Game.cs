using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Game
    {
        
        public Player player;
		public List<Day> days = new List<Day>();
		
	
        //constructor
        public Game()
        {
			days.Add(new Day("Monday"));
			days.Add(new Day("Tuesday"));
			days.Add(new Day("Wednesday"));
			days.Add(new Day("Thursday"));
			days.Add(new Day("Friday"));
			days.Add(new Day("Saturday"));
			days.Add(new Day("Sunday"));
		      
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
			for (int i = 0; i < 7; i++)
			{
				
				string playerName = GetPlayerName();
				player = new Player(playerName);
				days[i].MakeForecast(days);
				days[i].RunDay(days);
				player.inventory.DisplayInventory();
				
			}           



        }

   

       

    }
}
