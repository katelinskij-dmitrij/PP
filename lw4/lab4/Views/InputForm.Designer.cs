﻿namespace lab4.Views
{
	partial class InputForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.iterationsText = new System.Windows.Forms.TextBox();
            this.asyncCheckBox = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.outputText = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.inputText = new System.Windows.Forms.TextBox();
            this.getResultButton = new System.Windows.Forms.Button();
            this.timeList = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.iterationsText);
            this.panel1.Controls.Add(this.asyncCheckBox);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(408, 34);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(358, 118);
            this.panel1.TabIndex = 11;
            // 
            // iterationsText
            // 
            this.iterationsText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.iterationsText.Location = new System.Drawing.Point(186, 38);
            this.iterationsText.Name = "iterationsText";
            this.iterationsText.Size = new System.Drawing.Size(169, 26);
            this.iterationsText.TabIndex = 7;
            // 
            // asyncCheckBox
            // 
            this.asyncCheckBox.AutoSize = true;
            this.asyncCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.asyncCheckBox.Location = new System.Drawing.Point(235, 70);
            this.asyncCheckBox.Name = "asyncCheckBox";
            this.asyncCheckBox.Size = new System.Drawing.Size(96, 33);
            this.asyncCheckBox.TabIndex = 6;
            this.asyncCheckBox.Text = "async";
            this.asyncCheckBox.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(7, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Quantity of iterations";
            this.label3.Click += new System.EventHandler(this.Label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(30, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Output name";
            // 
            // outputText
            // 
            this.outputText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.outputText.Location = new System.Drawing.Point(30, 155);
            this.outputText.Name = "outputText";
            this.outputText.Size = new System.Drawing.Size(345, 34);
            this.outputText.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.inputText);
            this.groupBox1.Location = new System.Drawing.Point(24, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(358, 98);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(6, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Input name";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // inputText
            // 
            this.inputText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inputText.Location = new System.Drawing.Point(6, 50);
            this.inputText.Name = "inputText";
            this.inputText.Size = new System.Drawing.Size(346, 34);
            this.inputText.TabIndex = 1;
            // 
            // getResultButton
            // 
            this.getResultButton.Location = new System.Drawing.Point(280, 394);
            this.getResultButton.Name = "getResultButton";
            this.getResultButton.Size = new System.Drawing.Size(235, 49);
            this.getResultButton.TabIndex = 8;
            this.getResultButton.Text = "Result";
            this.getResultButton.UseVisualStyleBackColor = true;
            this.getResultButton.Click += new System.EventHandler(this.GetResultButton_Click);
            // 
            // timeList
            // 
            this.timeList.FormattingEnabled = true;
            this.timeList.ItemHeight = 16;
            this.timeList.Location = new System.Drawing.Point(17, 279);
            this.timeList.Name = "timeList";
            this.timeList.Size = new System.Drawing.Size(358, 84);
            this.timeList.TabIndex = 12;
            this.timeList.SelectedIndexChanged += new System.EventHandler(this.TimeList_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(48, 231);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(209, 29);
            this.label4.TabIndex = 13;
            this.label4.Text = "Time per iteration:";
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(21, 126);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(361, 82);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            // 
            // InputForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(800, 455);
            this.Controls.Add(this.outputText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.timeList);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.getResultButton);
            this.Name = "InputForm";
            this.Text = "InputWindow";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.CheckBox asyncCheckBox;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox outputText;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox inputText;
		private System.Windows.Forms.Button getResultButton;
		private System.Windows.Forms.TextBox iterationsText;
		private System.Windows.Forms.ListBox timeList;
		private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}