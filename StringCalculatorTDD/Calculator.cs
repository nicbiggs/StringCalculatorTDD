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
			int[] numbersArray = ParseInput.GetNumbers(numbers);
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

		public static int Subtract(string numbers)
		{
			int[] numbersArray = ParseInput.GetNumbers(numbers);
			string[] negativeNumbers = GetNegativeNumbers(numbersArray);

			if (negativeNumbers.Length > 0)
			{
				throw new CannotReadNegativeNumbersException(negativeNumbers.ToArray());
			}
			else
			{
				return GetDifference(numbersArray);
			}
		}

		private static int GetDifference(int[] numbers)
		{
			NumberCell firstValidCell = GetFirstValidCell(numbers);
			int subtractedAnswer = firstValidCell.Number;
			for (int i = firstValidCell.Index + 1; i < numbers.Length; i++)
			{
				if (numbers[i] <= 1000)
				{
					subtractedAnswer -= numbers[i];
				}
			}
			return subtractedAnswer;
		}

		private static NumberCell GetFirstValidCell(int[] numbers)
		{
			for(int i = 0; i < numbers.Length; i++)
			{
				if (numbers[i] >= 0 && numbers[i] <= 1000)
				{
					return new NumberCell(i, numbers[i]);
				}
			}
			return new NumberCell(0,0);
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
