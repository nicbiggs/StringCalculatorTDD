using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StringCalculatorTDD
{
	public partial class CalculatorForm : Form
	{
		public CalculatorForm()
		{
			InitializeComponent();
		}

		private void AddBtn_Click(object sender, EventArgs e)
		{
			try
			{
				AnswerLbl.Text = Calculator.Add(InputBox.Text).ToString();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void SubtractBtn_Click(object sender, EventArgs e)
		{
			try
			{
				AnswerLbl.Text = Calculator.Subtract(InputBox.Text).ToString();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}
	}
}
