using System;
using System.Windows.Forms;

namespace StringCalculatorTDD
{
	public partial class CalculatorForm : Form
	{
		public CalculatorForm()
		{
			InitializeComponent();
		}

		public static string GetCalculatorString(string delims, string numbers)
		{
			return (delims == "" ? numbers : "//" + delims + Environment.NewLine + numbers);
		}

		private void AddBtn_Click(object sender, EventArgs e)
		{
			try
			{
				string input = GetCalculatorString(DelimiterBox.Text, NumberBox.Text);
				AnswerLbl.Text = Calculator.Add(input).ToString();
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
				string input = GetCalculatorString(DelimiterBox.Text, NumberBox.Text);
				AnswerLbl.Text = Calculator.Subtract(input).ToString();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}
	}
}
