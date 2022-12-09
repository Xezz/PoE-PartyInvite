namespace PoE_PartyTool
{
	partial class SettingsDialog
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
			this.label4 = new System.Windows.Forms.Label();
			this.slider_Opacity = new System.Windows.Forms.TrackBar();
			this.btn_Layout1 = new System.Windows.Forms.Button();
			this.btn_Layout2 = new System.Windows.Forms.Button();
			this.btn_Layout3 = new System.Windows.Forms.Button();
			this.btn_ExitApp = new System.Windows.Forms.Button();
			this.btn_ShowHideTitleBar = new System.Windows.Forms.Button();
			this.lbl_WindowPosX = new System.Windows.Forms.Label();
			this.lbl_WindowPosY = new System.Windows.Forms.Label();
			this.tb_WindowPosX = new System.Windows.Forms.TextBox();
			this.tb_WindowPosY = new System.Windows.Forms.TextBox();
			this.lbl_WindowPosition = new System.Windows.Forms.Label();
			this.btn_SetWindowPos = new System.Windows.Forms.Button();
			this.btn_ResetWindowPos = new System.Windows.Forms.Button();
			this.btn_CloseSettingsDialog = new System.Windows.Forms.Button();
			this.btn_ShowHideXezzModeButton = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.slider_Opacity)).BeginInit();
			this.SuspendLayout();
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(12, 9);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(101, 29);
			this.label4.TabIndex = 14;
			this.label4.Text = "Opacity";
			// 
			// slider_Opacity
			// 
			this.slider_Opacity.Location = new System.Drawing.Point(119, 12);
			this.slider_Opacity.Maximum = 100;
			this.slider_Opacity.Minimum = 25;
			this.slider_Opacity.Name = "slider_Opacity";
			this.slider_Opacity.Size = new System.Drawing.Size(237, 45);
			this.slider_Opacity.TabIndex = 13;
			this.slider_Opacity.Value = 100;
			this.slider_Opacity.Scroll += new System.EventHandler(this.slider_Opacity_Scroll);
			// 
			// btn_Layout1
			// 
			this.btn_Layout1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_Layout1.Location = new System.Drawing.Point(12, 60);
			this.btn_Layout1.Name = "btn_Layout1";
			this.btn_Layout1.Size = new System.Drawing.Size(101, 37);
			this.btn_Layout1.TabIndex = 16;
			this.btn_Layout1.Text = "Layout 1";
			this.btn_Layout1.UseVisualStyleBackColor = true;
			this.btn_Layout1.Click += new System.EventHandler(this.btn_Layout1_Click);
			// 
			// btn_Layout2
			// 
			this.btn_Layout2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_Layout2.Location = new System.Drawing.Point(12, 103);
			this.btn_Layout2.Name = "btn_Layout2";
			this.btn_Layout2.Size = new System.Drawing.Size(101, 37);
			this.btn_Layout2.TabIndex = 17;
			this.btn_Layout2.Text = "Layout 2";
			this.btn_Layout2.UseVisualStyleBackColor = true;
			this.btn_Layout2.Click += new System.EventHandler(this.btn_Layout2_Click);
			// 
			// btn_Layout3
			// 
			this.btn_Layout3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_Layout3.Location = new System.Drawing.Point(12, 146);
			this.btn_Layout3.Name = "btn_Layout3";
			this.btn_Layout3.Size = new System.Drawing.Size(101, 37);
			this.btn_Layout3.TabIndex = 18;
			this.btn_Layout3.Text = "Layout 3";
			this.btn_Layout3.UseVisualStyleBackColor = true;
			this.btn_Layout3.Click += new System.EventHandler(this.btn_Layout3_Click);
			// 
			// btn_ExitApp
			// 
			this.btn_ExitApp.Location = new System.Drawing.Point(274, 200);
			this.btn_ExitApp.Name = "btn_ExitApp";
			this.btn_ExitApp.Size = new System.Drawing.Size(75, 23);
			this.btn_ExitApp.TabIndex = 20;
			this.btn_ExitApp.Text = "ExitApp";
			this.btn_ExitApp.UseVisualStyleBackColor = true;
			this.btn_ExitApp.Click += new System.EventHandler(this.btn_ExitApp_Click);
			// 
			// btn_ShowHideTitleBar
			// 
			this.btn_ShowHideTitleBar.Location = new System.Drawing.Point(131, 60);
			this.btn_ShowHideTitleBar.Name = "btn_ShowHideTitleBar";
			this.btn_ShowHideTitleBar.Size = new System.Drawing.Size(156, 23);
			this.btn_ShowHideTitleBar.TabIndex = 21;
			this.btn_ShowHideTitleBar.Text = "Show/Hide Title Bar";
			this.btn_ShowHideTitleBar.UseVisualStyleBackColor = true;
			this.btn_ShowHideTitleBar.Click += new System.EventHandler(this.btn_ShowHideTitleBar_Click);
			// 
			// lbl_WindowPosX
			// 
			this.lbl_WindowPosX.AutoSize = true;
			this.lbl_WindowPosX.Location = new System.Drawing.Point(130, 139);
			this.lbl_WindowPosX.Name = "lbl_WindowPosX";
			this.lbl_WindowPosX.Size = new System.Drawing.Size(17, 13);
			this.lbl_WindowPosX.TabIndex = 22;
			this.lbl_WindowPosX.Text = "X:";
			// 
			// lbl_WindowPosY
			// 
			this.lbl_WindowPosY.AutoSize = true;
			this.lbl_WindowPosY.Location = new System.Drawing.Point(130, 165);
			this.lbl_WindowPosY.Name = "lbl_WindowPosY";
			this.lbl_WindowPosY.Size = new System.Drawing.Size(17, 13);
			this.lbl_WindowPosY.TabIndex = 23;
			this.lbl_WindowPosY.Text = "Y:";
			// 
			// tb_WindowPosX
			// 
			this.tb_WindowPosX.Location = new System.Drawing.Point(153, 136);
			this.tb_WindowPosX.Name = "tb_WindowPosX";
			this.tb_WindowPosX.Size = new System.Drawing.Size(100, 20);
			this.tb_WindowPosX.TabIndex = 24;
			// 
			// tb_WindowPosY
			// 
			this.tb_WindowPosY.Location = new System.Drawing.Point(153, 163);
			this.tb_WindowPosY.Name = "tb_WindowPosY";
			this.tb_WindowPosY.Size = new System.Drawing.Size(100, 20);
			this.tb_WindowPosY.TabIndex = 25;
			// 
			// lbl_WindowPosition
			// 
			this.lbl_WindowPosition.AutoSize = true;
			this.lbl_WindowPosition.Location = new System.Drawing.Point(133, 120);
			this.lbl_WindowPosition.Name = "lbl_WindowPosition";
			this.lbl_WindowPosition.Size = new System.Drawing.Size(86, 13);
			this.lbl_WindowPosition.TabIndex = 26;
			this.lbl_WindowPosition.Text = "Window Position";
			// 
			// btn_SetWindowPos
			// 
			this.btn_SetWindowPos.Location = new System.Drawing.Point(259, 134);
			this.btn_SetWindowPos.Name = "btn_SetWindowPos";
			this.btn_SetWindowPos.Size = new System.Drawing.Size(90, 23);
			this.btn_SetWindowPos.TabIndex = 27;
			this.btn_SetWindowPos.Text = "Set Position";
			this.btn_SetWindowPos.UseVisualStyleBackColor = true;
			this.btn_SetWindowPos.Click += new System.EventHandler(this.btn_SetWindowPos_Click);
			// 
			// btn_ResetWindowPos
			// 
			this.btn_ResetWindowPos.Location = new System.Drawing.Point(259, 163);
			this.btn_ResetWindowPos.Name = "btn_ResetWindowPos";
			this.btn_ResetWindowPos.Size = new System.Drawing.Size(90, 23);
			this.btn_ResetWindowPos.TabIndex = 28;
			this.btn_ResetWindowPos.Text = "Reset Position";
			this.btn_ResetWindowPos.UseVisualStyleBackColor = true;
			this.btn_ResetWindowPos.Click += new System.EventHandler(this.btn_ResetWindowPos_Click);
			// 
			// btn_CloseSettingsDialog
			// 
			this.btn_CloseSettingsDialog.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.btn_CloseSettingsDialog.Location = new System.Drawing.Point(165, 200);
			this.btn_CloseSettingsDialog.Name = "btn_CloseSettingsDialog";
			this.btn_CloseSettingsDialog.Size = new System.Drawing.Size(88, 23);
			this.btn_CloseSettingsDialog.TabIndex = 29;
			this.btn_CloseSettingsDialog.Text = "Close Settings";
			this.btn_CloseSettingsDialog.UseVisualStyleBackColor = true;
			// 
			// btn_ShowHideXezzModeButton
			// 
			this.btn_ShowHideXezzModeButton.Location = new System.Drawing.Point(131, 89);
			this.btn_ShowHideXezzModeButton.Name = "btn_ShowHideXezzModeButton";
			this.btn_ShowHideXezzModeButton.Size = new System.Drawing.Size(156, 23);
			this.btn_ShowHideXezzModeButton.TabIndex = 30;
			this.btn_ShowHideXezzModeButton.Text = "Show/Hide XezzMode Button";
			this.btn_ShowHideXezzModeButton.UseVisualStyleBackColor = true;
			this.btn_ShowHideXezzModeButton.Click += new System.EventHandler(this.btn_ShowHideXezzModeButton_Click);
			// 
			// SettingsDialog
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(368, 242);
			this.Controls.Add(this.btn_ShowHideXezzModeButton);
			this.Controls.Add(this.btn_CloseSettingsDialog);
			this.Controls.Add(this.btn_ResetWindowPos);
			this.Controls.Add(this.btn_SetWindowPos);
			this.Controls.Add(this.lbl_WindowPosition);
			this.Controls.Add(this.tb_WindowPosY);
			this.Controls.Add(this.tb_WindowPosX);
			this.Controls.Add(this.lbl_WindowPosY);
			this.Controls.Add(this.lbl_WindowPosX);
			this.Controls.Add(this.btn_ShowHideTitleBar);
			this.Controls.Add(this.btn_ExitApp);
			this.Controls.Add(this.btn_Layout3);
			this.Controls.Add(this.btn_Layout2);
			this.Controls.Add(this.btn_Layout1);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.slider_Opacity);
			this.Name = "SettingsDialog";
			this.Text = "Settings Dialog";
			((System.ComponentModel.ISupportInitialize)(this.slider_Opacity)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TrackBar slider_Opacity;
		private System.Windows.Forms.Button btn_Layout1;
		private System.Windows.Forms.Button btn_Layout2;
		private System.Windows.Forms.Button btn_Layout3;
		private System.Windows.Forms.Button btn_ExitApp;
		private System.Windows.Forms.Button btn_ShowHideTitleBar;
		private System.Windows.Forms.Label lbl_WindowPosX;
		private System.Windows.Forms.Label lbl_WindowPosY;
		private System.Windows.Forms.TextBox tb_WindowPosX;
		private System.Windows.Forms.TextBox tb_WindowPosY;
		private System.Windows.Forms.Label lbl_WindowPosition;
		private System.Windows.Forms.Button btn_SetWindowPos;
		private System.Windows.Forms.Button btn_ResetWindowPos;
		private System.Windows.Forms.Button btn_CloseSettingsDialog;
		private System.Windows.Forms.Button btn_ShowHideXezzModeButton;
	}
}