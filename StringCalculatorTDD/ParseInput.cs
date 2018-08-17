using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringCalculatorTDD
{
	public static class ParseInput
	{
		public static string[] GetDelimiters(string numbers)
		{
			string[] delims = ParseDelimiters(GetDelimiterString(numbers));
			if (delims.Length > 1 || (delims.Length == 1 && delims[0] != ""))
			{
				return delims;
			}
			else
			{
				return new string[] { ",", " ", Environment.NewLine };
			}
		}

		private static string[] ParseDelimiters(string delimiters)
		{
			List<string> delims = new List<string>();
			if (delimiters.Contains("[") && delimiters.Contains("]"))
			{
				string[] unfinishedDelims = delimiters.Split(new string[] { "[" }, StringSplitOptions.RemoveEmptyEntries);
				foreach (string delim in unfinishedDelims)
				{
					delims.Add(delim.Replace("]", ""));
				}
			}
			else
			{
				delims.Add(delimiters);
			}
			return delims.ToArray();
		}

		private static string GetDelimiterString(string numbers)
		{
			if (numbers.StartsWith("//"))
			{
				int delimiterIndex = numbers.IndexOf("//") + 2;
				int endOfDelimiterIndex = GetEndOfDelimiterIndex(numbers);
				return numbers.Substring(delimiterIndex, endOfDelimiterIndex - delimiterIndex);
			}
			else
			{
				return "";
			}
		}

		private static int GetEndOfDelimiterIndex(string numbers)
		{
			if (numbers.IndexOf(Environment.NewLine) > -1)
			{
				return numbers.IndexOf(Environment.NewLine);
			}
			else
			{
				return 0;
			}
		}

		public static string GetNumberString(string numbers)
		{
			return numbers.Substring(GetStartOfNumbers(numbers));
		}

		private static int GetStartOfNumbers(string numbers)
		{
			if (numbers.StartsWith("//") && numbers.IndexOf(Environment.NewLine) > -1)
			{
				return numbers.IndexOf(Environment.NewLine) + Environment.NewLine.Length;
			}
			else
			{
				return 0;
			}
		}

		public static int[] GetNumbers(string numbers, string[] delimiters)
		{
			List<int> numberInts = new List<int>();
			string[] numberArray = numbers.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);
			foreach(string number in numberArray)
			{
				if (number.Trim(' ').Length != 0)
				{
					numberInts.Add(int.Parse(number));
				}
			}
			return numberInts.ToArray();
		}
	}
}
