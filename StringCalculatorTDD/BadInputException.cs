using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringCalculatorTDD
{
	public class BadInputException : Exception
	{
		public enum BadInputTypes
		{
			NA,
			NonNumber,
			TooManyNumbers
		}

		public BadInputException(BadInputTypes bit) : base(GetExceptionMessage(bit))
		{

		}

		static string GetExceptionMessage(BadInputTypes bit)
		{
			switch (bit)
			{
				case BadInputTypes.NA:
					return "Bad input";
				case BadInputTypes.NonNumber:
					return "Input other than a number was added";
				case BadInputTypes.TooManyNumbers:
					return "Too many numbers were added to the input";
				default:
					return "Just bad input";
			}
		}
	}
}
