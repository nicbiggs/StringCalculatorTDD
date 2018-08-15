using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringCalculatorTDD
{
	public static class Calculator
	{

		private static int Add(string numbers, string delimiters)
		{
			string[] numbersArray = numbers.Split(delimiters.ToCharArray());
			int summedAnswer = 0;

			foreach (string number in numbersArray)
			{
				if (number.Trim(' ').Length != 0)
				{
					summedAnswer += int.Parse(number);
				}
			}
			return summedAnswer;
		}

		public static int Add(string numbers)
		{
			string delimiters = ",\n";
			string numbersWithoutDelimiter = numbers;

			if (numbers.StartsWith("//"))
			{
				int delimiterIndex = numbers.IndexOf("//") + 2;
				delimiters = numbers.Substring(delimiterIndex, 1);
				numbersWithoutDelimiter = numbers.Substring(numbers.IndexOf('\n') + 1);
			}

			return Add(numbersWithoutDelimiter, delimiters);
		}
	}
}
