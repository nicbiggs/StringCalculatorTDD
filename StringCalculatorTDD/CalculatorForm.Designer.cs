﻿namespace StringCalculatorTDD
{
	partial class CalculatorForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.AddBtn = new System.Windows.Forms.Button();
			this.NumberBox = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.AnswerLbl = new System.Windows.Forms.Label();
			this.SubtractBtn = new System.Windows.Forms.Button();
			this.DelimiterBox = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// AddBtn
			// 
			this.AddBtn.Location = new System.Drawing.Point(12, 282);
			this.AddBtn.Name = "AddBtn";
			this.AddBtn.Size = new System.Drawing.Size(75, 23);
			this.AddBtn.TabIndex = 0;
			this.AddBtn.Text = "Add";
			this.AddBtn.UseVisualStyleBackColor = true;
			this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
			// 
			// NumberBox
			// 
			this.NumberBox.Location = new System.Drawing.Point(44, 113);
			this.NumberBox.Multiline = true;
			this.NumberBox.Name = "NumberBox";
			this.NumberBox.Size = new System.Drawing.Size(206, 106);
			this.NumberBox.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(41, 65);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(209, 45);
			this.label1.TabIndex = 2;
			this.label1.Text = "Input String (numbers separated by commas and/or separate lines, or start with th" +
    "e custom delimiter(s) you listed):";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(92, 248);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(40, 13);
			this.label2.TabIndex = 3;
			this.label2.Text = "Result:";
			// 
			// AnswerLbl
			// 
			this.AnswerLbl.AutoSize = true;
			this.AnswerLbl.Location = new System.Drawing.Point(154, 248);
			this.AnswerLbl.Name = "AnswerLbl";
			this.AnswerLbl.Size = new System.Drawing.Size(0, 13);
			this.AnswerLbl.TabIndex = 4;
			// 
			// SubtractBtn
			// 
			this.SubtractBtn.Location = new System.Drawing.Point(211, 282);
			this.SubtractBtn.Name = "SubtractBtn";
			this.SubtractBtn.Size = new System.Drawing.Size(75, 23);
			this.SubtractBtn.TabIndex = 5;
			this.SubtractBtn.Text = "Subtract";
			this.SubtractBtn.UseVisualStyleBackColor = true;
			this.SubtractBtn.Click += new System.EventHandler(this.SubtractBtn_Click);
			// 
			// DelimiterBox
			// 
			this.DelimiterBox.Location = new System.Drawing.Point(44, 31);
			this.DelimiterBox.Name = "DelimiterBox";
			this.DelimiterBox.Size = new System.Drawing.Size(206, 20);
			this.DelimiterBox.TabIndex = 6;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(41, 15);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(198, 13);
			this.label3.TabIndex = 7;
			this.label3.Text = "Delimiter (for example: \"[ttt][xxxx]\" or \";\"):";
			// 
			// CalculatorForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(304, 314);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.DelimiterBox);
			this.Controls.Add(this.SubtractBtn);
			this.Controls.Add(this.AnswerLbl);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.NumberBox);
			this.Controls.Add(this.AddBtn);
			this.Name = "CalculatorForm";
			this.Text = "Calculator Form";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button AddBtn;
		private System.Windows.Forms.TextBox NumberBox;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label AnswerLbl;
		private System.Windows.Forms.Button SubtractBtn;
		private System.Windows.Forms.TextBox DelimiterBox;
		private System.Windows.Forms.Label label3;
	}
}

