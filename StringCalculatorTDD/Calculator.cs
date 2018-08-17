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
			string[] delimiters = ParseInput.GetDelimiters(numbers);
			string numbersWithoutDelimiter = ParseInput.GetNumberString(numbers);

			return Add(numbersWithoutDelimiter, delimiters);
		}

		private static int Add(string numbers, string[] delimiters)
		{
			int[] numbersArray = ParseInput.GetNumbers(numbers, delimiters);
			string[] negativeNumbers = GetNegativeNumbers(numbersArray);
			
			if (negativeNumbers.Length > 0)
			{
				throw new CannotReadNegativeNumbersException(negativeNumbers.ToArray());
			}
			else
			{
				return GetSum(numbersArray);
			}
		}

		private static int GetSum(int[] numbers)
		{
			int summedAnswer = 0;
			foreach (int number in numbers)
			{
				if (number <= 1000)
				{
					summedAnswer += number;
				}
			}
			return summedAnswer;
		}

		private static string[] GetNegativeNumbers(int[] numbers)
		{
			List<string> negativeNumbers = new List<string>();
			foreach (int number in numbers)
			{
				if (number < 0)
				{
					negativeNumbers.Add(number.ToString());
				}
			}
			return negativeNumbers.ToArray();
		}
	}
}
