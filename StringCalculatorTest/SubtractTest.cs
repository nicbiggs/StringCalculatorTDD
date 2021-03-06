﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StringCalculatorTDD;

namespace StringCalculatorTest
{
	[TestClass]
	public class SubtractTest
	{
		[TestMethod]
		public void When2NumbersAreUsedThenNoExceptionIsThrown()
		{
			Calculator.Subtract("1,2");
			Assert.IsTrue(true);
		}

		[TestMethod]
		[ExpectedException(typeof(FormatException))]
		public void WhenNonNumberIsUsedThenExceptionIsThrown()
		{
			Calculator.Subtract("1,t");
		}

		[TestMethod]
		public void WhenEmptyStringIsUsedThenReturnZero()
		{
			Assert.AreEqual(0, Calculator.Subtract(""));
		}

		[TestMethod]
		public void WhenOneNumberIsUsedReturnsThatNumber()
		{
			Assert.AreEqual(3, Calculator.Subtract("3"));
		}

		[TestMethod]
		public void WhenTwoNumbersAreUsedReturnsTheDifferenceOfThoseNumbers()
		{
			Assert.AreEqual(5 - 7, Calculator.Subtract("5,7"));
		}

		[TestMethod]
		public void WhenMultipleNumbersAreUsedReturnsTheDifferenceOfThoseNumbers()
		{
			Assert.AreEqual(5 - 17 - 2 - 81 - 6, Calculator.Subtract("5,17,2,81,6"));
		}

		[TestMethod]
		public void WhenNewLinesAreUsedBetweenNumbersTreatsThemAsCommas()
		{
			Assert.AreEqual(5 - 7 - 8, Calculator.Subtract("5,7" + Environment.NewLine + "8"));
		}

		[TestMethod]
		public void WhenDelimiterIsSpecifiedThenItIsUsedToSeparateNumbers()
		{
			Assert.AreEqual(3 - 20 - 1, Calculator.Subtract("//;" + Environment.NewLine + "3;20;1"));
		}

		[TestMethod]
		[ExpectedException(typeof(CannotReadNegativeNumbersException))]
		public void WhenNegativeNumberIsUsedThenExceptionIsThrown()
		{
			Calculator.Subtract("9,-6,2");
		}

		[TestMethod]
		public void WhenNegativeNumbersAreUsedThenExceptionIsThrown()
		{
			string message = "";
			try
			{
				Calculator.Subtract("9, -6, -7, 5");
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
			Assert.AreEqual(4 - 2, Calculator.Subtract("1200,1500,4,2"));
		}

		[TestMethod]
		public void WhenSpecifiedDelimiterisMoreThanOneCharacterThenItIsUsedToSeparateNumbers()
		{
			Assert.AreEqual(5 - 15 - 30, Calculator.Subtract("//[----]" + Environment.NewLine + "5----15----30"));
		}

		[TestMethod]
		public void WhenMultipleSpecifiedDelimitersAreUsedThenTheyAreUsedToSeparateNumbers()
		{
			Assert.AreEqual(5 - 5 - 6, Calculator.Subtract("//[t][c]" + Environment.NewLine + "5t5c6"));
		}

		[TestMethod]
		public void WhenMultipleSpecifiedDelimitersAreMoreThanOneCharacterThenTheyAreUsedToSeparateNumbers()
		{
			Assert.AreEqual(5 - 5 - 6, Calculator.Subtract("//[tt][cc]" + Environment.NewLine + "5tt5cc6"));
		}
	}
}
