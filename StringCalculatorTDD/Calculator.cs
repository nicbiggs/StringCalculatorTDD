using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringCalculatorTDD
{
	public static class Calculator
	{
		public static int Add(string numbers)
		{
			string[] delimiters = { ",", Environment.NewLine };
			string numbersWithoutDelimiter = numbers;

			if (numbers.StartsWith("//"))
			{
				int delimiterIndex = numbers.IndexOf("//") + 2;
				int endOfDelimiterIndex = 0;
				int startOfNumbers = 0;
				if (numbers.IndexOf(Environment.NewLine) > -1)
				{
					endOfDelimiterIndex = numbers.IndexOf(Environment.NewLine);
					startOfNumbers = endOfDelimiterIndex + Environment.NewLine.Length;
				}
				string customDelimiter = numbers.Substring(delimiterIndex, endOfDelimiterIndex - delimiterIndex);
				customDelimiter = customDelimiter.Trim('[', ']');

				delimiters = new string[] { customDelimiter };
				numbersWithoutDelimiter = numbers.Substring(startOfNumbers);
			}

			return Add(numbersWithoutDelimiter, delimiters);
		}

		private static int Add(string numbers, string[] delimiters)
		{
			string[] numbersArray = numbers.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);
			int summedAnswer = 0;
			List<string> negativeNumbers = new List<string>();

			foreach (string number in numbersArray)
			{
				if (number.Trim(' ').Length != 0)
				{
					int numberParsedOut = int.Parse(number);
					if (numberParsedOut < 0)
					{
						negativeNumbers.Add(number);
					}
					else if (numberParsedOut <= 1000)
					{
						summedAnswer += numberParsedOut;
					}
				}
			}
			if (negativeNumbers.Count > 0)
			{
				throw new CannotReadNegativeNumbersException(negativeNumbers.ToArray());
			}
			else
			{
				return summedAnswer;
			}
		}
	}
}
