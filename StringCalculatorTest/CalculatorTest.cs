using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StringCalculatorTDD;

namespace StringCalculatorTest
{
	[TestClass]
	public class CalculatorTest
	{
		[TestMethod]
		public void When2NumbersAreUsedThenNoExceptionIsThrown()
		{
			Calculator.Add("1,2");
			Assert.IsTrue(true);
		}

		[TestMethod]
		[ExpectedException(typeof(FormatException))]
		public void WhenNonNumberIsUsedThenExceptionIsThrown()
		{
			Calculator.Add("1,t");
		}

		[TestMethod]
		public void WhenEmptyStringIsUsedThenReturnZero()
		{
			Assert.AreEqual(0,Calculator.Add(""));
		}

		[TestMethod]
		public void WhenOneNumberIsUsedReturnsThatNumber()
		{
			Assert.AreEqual(3, Calculator.Add("3"));
		}

		[TestMethod]
		public void WhenTwoNumbersAreUsedReturnsTheSumOfThoseNumbers()
		{
			Assert.AreEqual(5 + 7, Calculator.Add("5,7"));
		}

		[TestMethod]
		public void WhenMultipleNumbersAreUsedReturnsTheSumOfThoseNumbers()
		{
			Assert.AreEqual(5 + 17 + 2 + 81 + 6, Calculator.Add("5,17,2,81,6"));
		}

		[TestMethod]
		public void WhenNewLinesAreUsedBetweenNumbersTreatsThemAsCommas()
		{
			Assert.AreEqual(5 + 7 + 8, Calculator.Add("5,7\n8"));
		}

		[TestMethod]
		public void WhenDelimiterIsSpecifiedThenItIsUsedToSeparateNumbers()
		{
			Assert.AreEqual(3 + 20 + 1, Calculator.Add("//;\n3;20;1"));
		}

		[TestMethod]
		[ExpectedException(typeof(CannotReadNegativeNumbersException))]
		public void WhenNegativeNumberIsUsedThenExceptionIsThrown()
		{
			Calculator.Add("9,-6,2");
		}

		[TestMethod]
		public void WhenNegativeNumbersAreUsedThenExceptionIsThrown()
		{
			string message = "";
			try
			{
				Calculator.Add("9, -6, -7, 5");
			}
			catch (CannotReadNegativeNumbersException ex)
			{
				message = ex.Message;
			}
			Assert.AreNotEqual(message, "");
			Assert.IsTrue(message.Contains("-6"));
			Assert.IsTrue(message.Contains("-7"));
		}

		[TestMethod]
		public void WhenNumbersBiggerThan1000AreUsedThenIgnore()
		{
			Assert.AreEqual(4+2,Calculator.Add("1200,1500,4,2"));
		}
	}
}
