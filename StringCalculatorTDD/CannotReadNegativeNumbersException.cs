using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringCalculatorTDD
{
	public class CannotReadNegativeNumbersException : Exception
	{

		public CannotReadNegativeNumbersException(string[] negativeNumbers) : base(GetExceptionMessage(negativeNumbers))
		{
			
		}

		static string GetExceptionMessage(string[] negativeNumbers)
		{
			return "Negative numbers not allowed: " + GetArrayAsString(negativeNumbers);
		}

		static string GetArrayAsString(string[] negativeNumbers)
		{
			string finalArray = "[";

			foreach (string number in negativeNumbers)
			{
				finalArray += number + ", ";
			}
			finalArray = finalArray.Substring(0,finalArray.Length - 2);
			finalArray += "]";
			return finalArray;
		}
	}
}
