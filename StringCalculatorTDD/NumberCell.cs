using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringCalculatorTDD
{
	public class NumberCell
	{
		public int Index { get; set; }
		public int Number { get; set; }

		public NumberCell(int index, int number)
		{
			Index = index;
			Number = number;
		}
	}
}
