﻿namespace StringCalculatorTDD
{
	partial class Form1
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
			this.SubmitBtn = new System.Windows.Forms.Button();
			this.InputBox = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.AnswerLbl = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// SubmitBtn
			// 
			this.SubmitBtn.Location = new System.Drawing.Point(105, 242);
			this.SubmitBtn.Name = "SubmitBtn";
			this.SubmitBtn.Size = new System.Drawing.Size(75, 23);
			this.SubmitBtn.TabIndex = 0;
			this.SubmitBtn.Text = "Submit";
			this.SubmitBtn.UseVisualStyleBackColor = true;
			this.SubmitBtn.Click += new System.EventHandler(this.SubmitBtn_Click);
			// 
			// InputBox
			// 
			this.InputBox.Location = new System.Drawing.Point(51, 71);
			this.InputBox.Multiline = true;
			this.InputBox.Name = "InputBox";
			this.InputBox.Size = new System.Drawing.Size(192, 106);
			this.InputBox.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(48, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(195, 59);
			this.label1.TabIndex = 2;
			this.label1.Text = "Input String (numbers separated by commas, separate lines, or start with your pre" +
    "ferred delimiter that you will use, for example: \"//[delimiter]\\n[numbers]\" plea" +
    "se):\r\n";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(92, 182);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(40, 13);
			this.label2.TabIndex = 3;
			this.label2.Text = "Result:";
			// 
			// AnswerLbl
			// 
			this.AnswerLbl.AutoSize = true;
			this.AnswerLbl.Location = new System.Drawing.Point(132, 207);
			this.AnswerLbl.Name = "AnswerLbl";
			this.AnswerLbl.Size = new System.Drawing.Size(0, 13);
			this.AnswerLbl.TabIndex = 4;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(298, 297);
			this.Controls.Add(this.AnswerLbl);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.InputBox);
			this.Controls.Add(this.SubmitBtn);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button SubmitBtn;
		private System.Windows.Forms.TextBox InputBox;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label AnswerLbl;
	}
}

