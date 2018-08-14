﻿using System;
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
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void SubmitBtn_Click(object sender, EventArgs e)
		{
			try
			{
				AnswerLbl.Text = Calculator.Add(InputBox.Text).ToString();
			}
			catch (FormatException ex)
			{
				MessageBox.Show(ex.Message);
			}
		}
	}
}
