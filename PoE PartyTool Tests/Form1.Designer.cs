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
			this.slider_Opacity = new System.Windows.Forms.TrackBar();
			this.label4 = new System.Windows.Forms.Label();
			this.btn_left = new System.Windows.Forms.Button();
			this.btn_right = new System.Windows.Forms.Button();
			this.btn_inv = new System.Windows.Forms.Button();
			this.btn_remove = new System.Windows.Forms.Button();
			this.lbl_requestCount = new System.Windows.Forms.Label();
			this.lbl_currentNr = new System.Windows.Forms.Label();
			this.lbl_currentName = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.cb_XezzMode = new System.Windows.Forms.CheckBox();
			((System.ComponentModel.ISupportInitialize)(this.slider_Opacity)).BeginInit();
			this.SuspendLayout();
			// 
			// slider_Opacity
			// 
			this.slider_Opacity.Location = new System.Drawing.Point(0, 10);
			this.slider_Opacity.Maximum = 100;
			this.slider_Opacity.Minimum = 25;
			this.slider_Opacity.Name = "slider_Opacity";
			this.slider_Opacity.Size = new System.Drawing.Size(84, 45);
			this.slider_Opacity.TabIndex = 11;
			this.slider_Opacity.Value = 100;
			this.slider_Opacity.Scroll += new System.EventHandler(this.trackBar1_Scroll);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(17, 2);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(43, 13);
			this.label4.TabIndex = 12;
			this.label4.Text = "Opacity";
			// 
			// btn_left
			// 
			this.btn_left.Enabled = false;
			this.btn_left.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_left.Location = new System.Drawing.Point(83, 2);
			this.btn_left.Name = "btn_left";
			this.btn_left.Size = new System.Drawing.Size(33, 23);
			this.btn_left.TabIndex = 13;
			this.btn_left.Text = "<-";
			this.btn_left.UseVisualStyleBackColor = true;
			this.btn_left.Click += new System.EventHandler(this.btn_left_Click);
			// 
			// btn_right
			// 
			this.btn_right.Enabled = false;
			this.btn_right.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_right.Location = new System.Drawing.Point(125, 2);
			this.btn_right.Name = "btn_right";
			this.btn_right.Size = new System.Drawing.Size(33, 23);
			this.btn_right.TabIndex = 14;
			this.btn_right.Text = "->";
			this.btn_right.UseVisualStyleBackColor = true;
			this.btn_right.Click += new System.EventHandler(this.btn_right_Click);
			// 
			// btn_inv
			// 
			this.btn_inv.Enabled = false;
			this.btn_inv.Location = new System.Drawing.Point(83, 31);
			this.btn_inv.Name = "btn_inv";
			this.btn_inv.Size = new System.Drawing.Size(75, 23);
			this.btn_inv.TabIndex = 15;
			this.btn_inv.Text = "inv";
			this.btn_inv.UseVisualStyleBackColor = true;
			this.btn_inv.Click += new System.EventHandler(this.btn_inv_Click);
			// 
			// btn_remove
			// 
			this.btn_remove.Enabled = false;
			this.btn_remove.Location = new System.Drawing.Point(83, 57);
			this.btn_remove.Name = "btn_remove";
			this.btn_remove.Size = new System.Drawing.Size(75, 23);
			this.btn_remove.TabIndex = 16;
			this.btn_remove.Text = "remove";
			this.btn_remove.UseVisualStyleBackColor = true;
			this.btn_remove.Click += new System.EventHandler(this.btn_remove_Click);
			// 
			// lbl_requestCount
			// 
			this.lbl_requestCount.AutoSize = true;
			this.lbl_requestCount.Location = new System.Drawing.Point(57, 45);
			this.lbl_requestCount.Name = "lbl_requestCount";
			this.lbl_requestCount.Size = new System.Drawing.Size(13, 13);
			this.lbl_requestCount.TabIndex = 17;
			this.lbl_requestCount.Text = "0";
			// 
			// lbl_currentNr
			// 
			this.lbl_currentNr.AutoSize = true;
			this.lbl_currentNr.Location = new System.Drawing.Point(57, 67);
			this.lbl_currentNr.Name = "lbl_currentNr";
			this.lbl_currentNr.Size = new System.Drawing.Size(13, 13);
			this.lbl_currentNr.TabIndex = 18;
			this.lbl_currentNr.Text = "0";
			// 
			// lbl_currentName
			// 
			this.lbl_currentName.AutoSize = true;
			this.lbl_currentName.Location = new System.Drawing.Point(9, 89);
			this.lbl_currentName.Name = "lbl_currentName";
			this.lbl_currentName.Size = new System.Drawing.Size(33, 13);
			this.lbl_currentName.TabIndex = 19;
			this.lbl_currentName.Text = "None";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(-2, 45);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(49, 13);
			this.label1.TabIndex = 20;
			this.label1.Text = "Pending:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(-2, 67);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(52, 13);
			this.label2.TabIndex = 21;
			this.label2.Text = "Selected:";
			// 
			// cb_XezzMode
			// 
			this.cb_XezzMode.AutoSize = true;
			this.cb_XezzMode.Location = new System.Drawing.Point(168, 6);
			this.cb_XezzMode.Name = "cb_XezzMode";
			this.cb_XezzMode.Size = new System.Drawing.Size(76, 17);
			this.cb_XezzMode.TabIndex = 22;
			this.cb_XezzMode.Text = "XezzMode";
			this.cb_XezzMode.UseVisualStyleBackColor = true;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(264, 113);
			this.Controls.Add(this.cb_XezzMode);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.lbl_currentName);
			this.Controls.Add(this.lbl_currentNr);
			this.Controls.Add(this.lbl_requestCount);
			this.Controls.Add(this.btn_remove);
			this.Controls.Add(this.btn_inv);
			this.Controls.Add(this.btn_right);
			this.Controls.Add(this.btn_left);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.slider_Opacity);
			this.Name = "Form1";
			this.Text = "Form1";
			((System.ComponentModel.ISupportInitialize)(this.slider_Opacity)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.TrackBar slider_Opacity;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button btn_left;
		private System.Windows.Forms.Button btn_right;
		private System.Windows.Forms.Button btn_inv;
		private System.Windows.Forms.Button btn_remove;
		private System.Windows.Forms.Label lbl_requestCount;
		private System.Windows.Forms.Label lbl_currentNr;
		private System.Windows.Forms.Label lbl_currentName;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.CheckBox cb_XezzMode;
	}
}

