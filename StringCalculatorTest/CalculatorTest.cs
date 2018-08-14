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
	}
}
