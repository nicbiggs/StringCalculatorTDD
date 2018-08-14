﻿using System;
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
			string[] numbersArray = numbers.Split(',');
			int summedAnswer = 0;
			if (numbersArray.Length > 2)
			{
				throw new BadInputException(BadInputException.BadInputTypes.TooManyNumbers);
			}
			else
			{
				foreach (string number in numbersArray)
				{
					if (number.Trim(' ').Length != 0)
					{
						summedAnswer += int.Parse(number);
					}
				}
			}
			return summedAnswer;
		}
	}
}
