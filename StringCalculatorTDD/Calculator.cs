using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringCalculatorTDD
{
	public static class Calculator
	{
		public static void Add(string numbers)
		{
			string[] numbersArray = numbers.Split(',');
			if (numbersArray.Length > 2)
			{
				throw new BadInputException(BadInputException.BadInputTypes.TooManyNumbers);
			}
			else
			{
				foreach (string number in numbersArray)
				{
					int.Parse(number);
				}
			}
		}
	}
}
