namespace PoE_PartyTool
{
	partial class form_InviteTool
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
			this.btn_left = new System.Windows.Forms.Button();
			this.btn_right = new System.Windows.Forms.Button();
			this.btn_inv = new System.Windows.Forms.Button();
			this.btn_remove = new System.Windows.Forms.Button();
			this.lbl_requestCount = new System.Windows.Forms.Label();
			this.lbl_currentNr = new System.Windows.Forms.Label();
			this.lbl_currentName = new System.Windows.Forms.Label();
			this.lbl_Pending = new System.Windows.Forms.Label();
			this.lbl_Selected = new System.Windows.Forms.Label();
			this.cb_XezzMode = new System.Windows.Forms.CheckBox();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// btn_left
			// 
			this.btn_left.Enabled = false;
			this.btn_left.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_left.Location = new System.Drawing.Point(87, 25);
			this.btn_left.Name = "btn_left";
			this.btn_left.Size = new System.Drawing.Size(30, 23);
			this.btn_left.TabIndex = 13;
			this.btn_left.Text = "<-";
			this.btn_left.UseVisualStyleBackColor = true;
			this.btn_left.Click += new System.EventHandler(this.btn_left_Click);
			// 
			// btn_right
			// 
			this.btn_right.Enabled = false;
			this.btn_right.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_right.Location = new System.Drawing.Point(125, 25);
			this.btn_right.Name = "btn_right";
			this.btn_right.Size = new System.Drawing.Size(30, 23);
			this.btn_right.TabIndex = 14;
			this.btn_right.Text = "->";
			this.btn_right.UseVisualStyleBackColor = true;
			this.btn_right.Click += new System.EventHandler(this.btn_right_Click);
			// 
			// btn_inv
			// 
			this.btn_inv.Enabled = false;
			this.btn_inv.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_inv.Location = new System.Drawing.Point(87, 52);
			this.btn_inv.Name = "btn_inv";
			this.btn_inv.Size = new System.Drawing.Size(50, 23);
			this.btn_inv.TabIndex = 15;
			this.btn_inv.Text = "inv";
			this.btn_inv.UseVisualStyleBackColor = true;
			this.btn_inv.Click += new System.EventHandler(this.btn_inv_Click);
			// 
			// btn_remove
			// 
			this.btn_remove.Enabled = false;
			this.btn_remove.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_remove.Location = new System.Drawing.Point(145, 52);
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
			this.lbl_requestCount.Location = new System.Drawing.Point(71, 30);
			this.lbl_requestCount.Name = "lbl_requestCount";
			this.lbl_requestCount.Size = new System.Drawing.Size(13, 13);
			this.lbl_requestCount.TabIndex = 17;
			this.lbl_requestCount.Text = "0";
			// 
			// lbl_currentNr
			// 
			this.lbl_currentNr.AutoSize = true;
			this.lbl_currentNr.Location = new System.Drawing.Point(71, 57);
			this.lbl_currentNr.Name = "lbl_currentNr";
			this.lbl_currentNr.Size = new System.Drawing.Size(13, 13);
			this.lbl_currentNr.TabIndex = 18;
			this.lbl_currentNr.Text = "0";
			// 
			// lbl_currentName
			// 
			this.lbl_currentName.AutoSize = true;
			this.lbl_currentName.Location = new System.Drawing.Point(10, 80);
			this.lbl_currentName.Name = "lbl_currentName";
			this.lbl_currentName.Size = new System.Drawing.Size(33, 13);
			this.lbl_currentName.TabIndex = 19;
			this.lbl_currentName.Text = "None";
			// 
			// lbl_Pending
			// 
			this.lbl_Pending.AutoSize = true;
			this.lbl_Pending.Location = new System.Drawing.Point(12, 30);
			this.lbl_Pending.Name = "lbl_Pending";
			this.lbl_Pending.Size = new System.Drawing.Size(49, 13);
			this.lbl_Pending.TabIndex = 20;
			this.lbl_Pending.Text = "Pending:";
			// 
			// lbl_Selected
			// 
			this.lbl_Selected.AutoSize = true;
			this.lbl_Selected.Location = new System.Drawing.Point(12, 57);
			this.lbl_Selected.Name = "lbl_Selected";
			this.lbl_Selected.Size = new System.Drawing.Size(52, 13);
			this.lbl_Selected.TabIndex = 21;
			this.lbl_Selected.Text = "Selected:";
			// 
			// cb_XezzMode
			// 
			this.cb_XezzMode.AutoSize = true;
			this.cb_XezzMode.Location = new System.Drawing.Point(164, 31);
			this.cb_XezzMode.Name = "cb_XezzMode";
			this.cb_XezzMode.Size = new System.Drawing.Size(76, 17);
			this.cb_XezzMode.TabIndex = 22;
			this.cb_XezzMode.Text = "XezzMode";
			this.cb_XezzMode.UseVisualStyleBackColor = true;
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(264, 24);
			this.menuStrip1.TabIndex = 23;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// settingsToolStripMenuItem
			// 
			this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
			this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
			this.settingsToolStripMenuItem.Text = "Settings";
			this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
			// 
			// form_InviteTool
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(264, 105);
			this.Controls.Add(this.cb_XezzMode);
			this.Controls.Add(this.lbl_Selected);
			this.Controls.Add(this.lbl_Pending);
			this.Controls.Add(this.lbl_currentName);
			this.Controls.Add(this.lbl_currentNr);
			this.Controls.Add(this.lbl_requestCount);
			this.Controls.Add(this.btn_remove);
			this.Controls.Add(this.btn_inv);
			this.Controls.Add(this.btn_right);
			this.Controls.Add(this.btn_left);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "form_InviteTool";
			this.Text = "Invite Tool";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		public System.Windows.Forms.Button btn_left;
		public System.Windows.Forms.Button btn_right;
		public System.Windows.Forms.Button btn_inv;
		public System.Windows.Forms.Button btn_remove;
		public System.Windows.Forms.Label lbl_requestCount;
		public System.Windows.Forms.Label lbl_currentNr;
		public System.Windows.Forms.Label lbl_currentName;
		public System.Windows.Forms.Label lbl_Pending;
		public System.Windows.Forms.Label lbl_Selected;
		public System.Windows.Forms.CheckBox cb_XezzMode;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
	}
}

