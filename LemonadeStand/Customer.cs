using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Customer
    {
		//member variables (HAS A)
		int percentChanceToBuy = 100;
		double temperatureProbability;
		double conditionProbability;
		double priceProbability;
		



		//constructor
		public Customer()
        {
		
        }

		//member methods (CAN DO)
		public void ChanceToBuyPrice()
		{

		}

		public double ChanceToBuyTemperature(Day day)
		{
			if ( day.Temperature<= 70)
			{
				temperatureProbability = percentChanceToBuy * 0.50;
			}
			else if (day.Temperature <= 85)
			{
				temperatureProbability = percentChanceToBuy * 0.70;
			}
			else
			{
				temperatureProbability = percentChanceToBuy * 0.80;
			}
			return temperatureProbability;
		}

		public double ChanceToBuyCondition(Day day)
		{
			switch (day.Condition)
			{
				case "rainy":
					conditionProbability = percentChanceToBuy * 0.40;
					break;
				case "overcast":
					conditionProbability = percentChanceToBuy * 0.50;
					break;
				case "hazy":
					conditionProbability = percentChanceToBuy * 0.60;
					break;
				case "cloudy":
					conditionProbability = percentChanceToBuy * 0.70;
					break;
				case "sunny":
					conditionProbability = percentChanceToBuy * 0.80;
					break;
				default:
					break;
			}
			return conditionProbability;

		}

		

	}

}
