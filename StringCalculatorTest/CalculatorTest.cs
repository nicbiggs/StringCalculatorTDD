using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StringCalculatorTDD;

namespace StringCalculatorTest
{
	[TestClass]
	public class CalculatorTest
	{
		[TestMethod]
		[ExpectedException(typeof(BadInputException))]
		public void WhenMoreThan2NumbersAreUsedThenExceptionIsThrown()
		{
			Calculator.Add("1,2,3");
		}

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
	}
}
