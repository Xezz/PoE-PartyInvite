﻿namespace PoE_PartyTool_Tests
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
			this.lbl_LastLine = new System.Windows.Forms.Label();
			this.lbl_PoEFocus = new System.Windows.Forms.Label();
			this.btn_ReadLine = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.btn_CheckFocus = new System.Windows.Forms.Button();
			this.cb_AutoFocusCheck = new System.Windows.Forms.CheckBox();
			this.SuspendLayout();
			// 
			// lbl_LastLine
			// 
			this.lbl_LastLine.AutoSize = true;
			this.lbl_LastLine.Location = new System.Drawing.Point(149, 34);
			this.lbl_LastLine.Name = "lbl_LastLine";
			this.lbl_LastLine.Size = new System.Drawing.Size(27, 13);
			this.lbl_LastLine.TabIndex = 0;
			this.lbl_LastLine.Text = "Line";
			// 
			// lbl_PoEFocus
			// 
			this.lbl_PoEFocus.AutoSize = true;
			this.lbl_PoEFocus.Location = new System.Drawing.Point(160, 131);
			this.lbl_PoEFocus.Name = "lbl_PoEFocus";
			this.lbl_PoEFocus.Size = new System.Drawing.Size(36, 13);
			this.lbl_PoEFocus.TabIndex = 1;
			this.lbl_PoEFocus.Text = "Focus";
			// 
			// btn_ReadLine
			// 
			this.btn_ReadLine.Location = new System.Drawing.Point(49, 29);
			this.btn_ReadLine.Name = "btn_ReadLine";
			this.btn_ReadLine.Size = new System.Drawing.Size(75, 23);
			this.btn_ReadLine.TabIndex = 3;
			this.btn_ReadLine.Text = "Read Line";
			this.btn_ReadLine.UseVisualStyleBackColor = true;
			this.btn_ReadLine.Click += new System.EventHandler(this.btn_ReadLine_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(15, 13);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(145, 13);
			this.label1.TabIndex = 4;
			this.label1.Text = "Read Last Line From Log File";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(15, 100);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(88, 13);
			this.label2.TabIndex = 5;
			this.label2.Text = "Is PoE Focused?";
			// 
			// btn_CheckFocus
			// 
			this.btn_CheckFocus.Location = new System.Drawing.Point(43, 116);
			this.btn_CheckFocus.Name = "btn_CheckFocus";
			this.btn_CheckFocus.Size = new System.Drawing.Size(85, 23);
			this.btn_CheckFocus.TabIndex = 6;
			this.btn_CheckFocus.Text = "Check Focus";
			this.btn_CheckFocus.UseVisualStyleBackColor = true;
			this.btn_CheckFocus.Click += new System.EventHandler(this.btn_CheckFocus_Click);
			// 
			// cb_AutoFocusCheck
			// 
			this.cb_AutoFocusCheck.AutoSize = true;
			this.cb_AutoFocusCheck.Location = new System.Drawing.Point(18, 145);
			this.cb_AutoFocusCheck.Name = "cb_AutoFocusCheck";
			this.cb_AutoFocusCheck.Size = new System.Drawing.Size(133, 17);
			this.cb_AutoFocusCheck.TabIndex = 8;
			this.cb_AutoFocusCheck.Text = "AutomaticFocusCheck";
			this.cb_AutoFocusCheck.UseVisualStyleBackColor = true;
			this.cb_AutoFocusCheck.CheckedChanged += new System.EventHandler(this.cb_AutoFocusCheck_CheckedChanged);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(786, 201);
			this.Controls.Add(this.cb_AutoFocusCheck);
			this.Controls.Add(this.btn_CheckFocus);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btn_ReadLine);
			this.Controls.Add(this.lbl_PoEFocus);
			this.Controls.Add(this.lbl_LastLine);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lbl_LastLine;
		private System.Windows.Forms.Label lbl_PoEFocus;
		private System.Windows.Forms.Button btn_ReadLine;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button btn_CheckFocus;
		private System.Windows.Forms.CheckBox cb_AutoFocusCheck;
	}
}

