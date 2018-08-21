using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StringCalculatorTDD;

namespace StringCalculatorTest
{
	[TestClass]
	public class CalculatorFormTest
	{
		[TestMethod]
		public void WhenReadingMulticharacterDelimiterThenOutputIsCorrect()
		{
			Assert.AreEqual("//[nn]" + Environment.NewLine + "1nn2nn3nn4",CalculatorForm.GetCalculatorString("[nn]", "1nn2nn3nn4"));
		}

		[TestMethod]
		public void WhenReadingSingleCharacterDelimiterThenOutputIsCorrect()
		{
			Assert.AreEqual("//|" + Environment.NewLine + "1|2|3|4", CalculatorForm.GetCalculatorString("|", "1|2|3|4"));
		}

		[TestMethod]
		public void WhenReadingMultipleMulticharacterDelimitersThenOutputIsCorrect()
		{
			Assert.AreEqual("//[nn][zv]" + Environment.NewLine + "1zv2nn3zv4", CalculatorForm.GetCalculatorString("[nn][zv]", "1zv2nn3zv4"));
		}

		[TestMethod]
		[ExpectedException(typeof(System.FormatException))]
		public void WhenReadingIncorrectInputStringsThenCalculatorExceptionIsThrown()
		{
			string input = CalculatorForm.GetCalculatorString("t", "1nn2nn3nn4");
			Calculator.Add(input);
		}
	}
}
