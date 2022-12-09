using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PoE_PartyTool
{
	public partial class SettingsDialog : Form
	{
		form_InviteTool mainDialogWindow;

		public SettingsDialog(form_InviteTool main)
		{
			InitializeComponent();

			mainDialogWindow = main;
		}

		private void slider_Opacity_Scroll(object sender, EventArgs e)
		{
			mainDialogWindow.Opacity = Convert.ToDouble(slider_Opacity.Value) / 100;
		}

		private void btn_Layout1_Click(object sender, EventArgs e)
		{
			mainDialogWindow.btn_left.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			mainDialogWindow.btn_left.Location = new System.Drawing.Point(87, 25);
			mainDialogWindow.btn_left.Name = "btn_left";
			mainDialogWindow.btn_left.Size = new System.Drawing.Size(30, 23);
			mainDialogWindow.btn_left.TabIndex = 13;
			mainDialogWindow.btn_left.Text = "<-";
			mainDialogWindow.btn_left.UseVisualStyleBackColor = true;

			mainDialogWindow.btn_right.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			mainDialogWindow.btn_right.Location = new System.Drawing.Point(125, 25);
			mainDialogWindow.btn_right.Name = "btn_right";
			mainDialogWindow.btn_right.Size = new System.Drawing.Size(30, 23);
			mainDialogWindow.btn_right.TabIndex = 14;
			mainDialogWindow.btn_right.Text = "->";
			mainDialogWindow.btn_right.UseVisualStyleBackColor = true;

			mainDialogWindow.btn_inv.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			mainDialogWindow.btn_inv.Location = new System.Drawing.Point(87, 52);
			mainDialogWindow.btn_inv.Name = "btn_inv";
			mainDialogWindow.btn_inv.Size = new System.Drawing.Size(50, 23);
			mainDialogWindow.btn_inv.TabIndex = 15;
			mainDialogWindow.btn_inv.Text = "inv";
			mainDialogWindow.btn_inv.UseVisualStyleBackColor = true;

			mainDialogWindow.btn_remove.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			mainDialogWindow.btn_remove.Location = new System.Drawing.Point(145, 52);
			mainDialogWindow.btn_remove.Name = "btn_remove";
			mainDialogWindow.btn_remove.Size = new System.Drawing.Size(75, 23);
			mainDialogWindow.btn_remove.TabIndex = 16;
			mainDialogWindow.btn_remove.Text = "remove";
			mainDialogWindow.btn_remove.UseVisualStyleBackColor = true;

			mainDialogWindow.lbl_requestCount.AutoSize = true;
			mainDialogWindow.lbl_requestCount.Location = new System.Drawing.Point(71, 30);
			mainDialogWindow.lbl_requestCount.Name = "lbl_requestCount";
			mainDialogWindow.lbl_requestCount.Size = new System.Drawing.Size(13, 13);
			mainDialogWindow.lbl_requestCount.TabIndex = 17;
			mainDialogWindow.lbl_requestCount.Text = "0";

			mainDialogWindow.lbl_currentNr.AutoSize = true;
			mainDialogWindow.lbl_currentNr.Location = new System.Drawing.Point(71, 57);
			mainDialogWindow.lbl_currentNr.Name = "lbl_currentNr";
			mainDialogWindow.lbl_currentNr.Size = new System.Drawing.Size(13, 13);
			mainDialogWindow.lbl_currentNr.TabIndex = 18;
			mainDialogWindow.lbl_currentNr.Text = "0";

			mainDialogWindow.lbl_currentName.AutoSize = true;
			mainDialogWindow.lbl_currentName.Location = new System.Drawing.Point(10, 80);
			mainDialogWindow.lbl_currentName.Name = "lbl_currentName";
			mainDialogWindow.lbl_currentName.Size = new System.Drawing.Size(33, 13);
			mainDialogWindow.lbl_currentName.TabIndex = 19;
			mainDialogWindow.lbl_currentName.Text = "None";

			mainDialogWindow.lbl_Pending.AutoSize = true;
			mainDialogWindow.lbl_Pending.Location = new System.Drawing.Point(12, 30);
			mainDialogWindow.lbl_Pending.Name = "lbl_Pending";
			mainDialogWindow.lbl_Pending.Size = new System.Drawing.Size(17, 13);
			mainDialogWindow.lbl_Pending.TabIndex = 20;
			mainDialogWindow.lbl_Pending.Text = "Pending:";

			mainDialogWindow.lbl_Selected.AutoSize = true;
			mainDialogWindow.lbl_Selected.Location = new System.Drawing.Point(12, 57);
			mainDialogWindow.lbl_Selected.Name = "lbl_Selected";
			mainDialogWindow.lbl_Selected.Size = new System.Drawing.Size(17, 13);
			mainDialogWindow.lbl_Selected.TabIndex = 21;
			mainDialogWindow.lbl_Selected.Text = "Selected:";

			mainDialogWindow.cb_XezzMode.AutoSize = true;
			mainDialogWindow.cb_XezzMode.Location = new System.Drawing.Point(164, 31);
			mainDialogWindow.cb_XezzMode.Name = "cb_XezzMode";
			mainDialogWindow.cb_XezzMode.Size = new System.Drawing.Size(42, 17);
			mainDialogWindow.cb_XezzMode.TabIndex = 22;
			mainDialogWindow.cb_XezzMode.Text = "XezzMode";
			mainDialogWindow.cb_XezzMode.UseVisualStyleBackColor = true;

			mainDialogWindow.ClientSize = new System.Drawing.Size(264, 105);
		}

		private void btn_Layout2_Click(object sender, EventArgs e)
		{
			mainDialogWindow.btn_left.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			mainDialogWindow.btn_left.Location = new System.Drawing.Point(87, 25);
			mainDialogWindow.btn_left.Name = "btn_left";
			mainDialogWindow.btn_left.Size = new System.Drawing.Size(30, 23);
			mainDialogWindow.btn_left.TabIndex = 13;
			mainDialogWindow.btn_left.Text = "<-";
			mainDialogWindow.btn_left.UseVisualStyleBackColor = true;

			mainDialogWindow.btn_right.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			mainDialogWindow.btn_right.Location = new System.Drawing.Point(125, 25);
			mainDialogWindow.btn_right.Name = "btn_right";
			mainDialogWindow.btn_right.Size = new System.Drawing.Size(30, 23);
			mainDialogWindow.btn_right.TabIndex = 14;
			mainDialogWindow.btn_right.Text = "->";
			mainDialogWindow.btn_right.UseVisualStyleBackColor = true;

			mainDialogWindow.btn_inv.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			mainDialogWindow.btn_inv.Location = new System.Drawing.Point(87, 52);
			mainDialogWindow.btn_inv.Name = "btn_inv";
			mainDialogWindow.btn_inv.Size = new System.Drawing.Size(50, 23);
			mainDialogWindow.btn_inv.TabIndex = 15;
			mainDialogWindow.btn_inv.Text = "inv";
			mainDialogWindow.btn_inv.UseVisualStyleBackColor = true;

			mainDialogWindow.btn_remove.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			mainDialogWindow.btn_remove.Location = new System.Drawing.Point(145, 52);
			mainDialogWindow.btn_remove.Name = "btn_remove";
			mainDialogWindow.btn_remove.Size = new System.Drawing.Size(75, 23);
			mainDialogWindow.btn_remove.TabIndex = 16;
			mainDialogWindow.btn_remove.Text = "remove";
			mainDialogWindow.btn_remove.UseVisualStyleBackColor = true;

			mainDialogWindow.lbl_requestCount.AutoSize = true;
			mainDialogWindow.lbl_requestCount.Location = new System.Drawing.Point(71, 30);
			mainDialogWindow.lbl_requestCount.Name = "lbl_requestCount";
			mainDialogWindow.lbl_requestCount.Size = new System.Drawing.Size(13, 13);
			mainDialogWindow.lbl_requestCount.TabIndex = 17;
			mainDialogWindow.lbl_requestCount.Text = "0";

			mainDialogWindow.lbl_currentNr.AutoSize = true;
			mainDialogWindow.lbl_currentNr.Location = new System.Drawing.Point(71, 57);
			mainDialogWindow.lbl_currentNr.Name = "lbl_currentNr";
			mainDialogWindow.lbl_currentNr.Size = new System.Drawing.Size(13, 13);
			mainDialogWindow.lbl_currentNr.TabIndex = 18;
			mainDialogWindow.lbl_currentNr.Text = "0";

			mainDialogWindow.lbl_currentName.AutoSize = true;
			mainDialogWindow.lbl_currentName.Location = new System.Drawing.Point(70, 6);
			mainDialogWindow.lbl_currentName.Name = "lbl_currentName";
			mainDialogWindow.lbl_currentName.Size = new System.Drawing.Size(33, 13);
			mainDialogWindow.lbl_currentName.TabIndex = 19;
			mainDialogWindow.lbl_currentName.Text = "None";

			mainDialogWindow.lbl_Pending.AutoSize = true;
			mainDialogWindow.lbl_Pending.Location = new System.Drawing.Point(12, 30);
			mainDialogWindow.lbl_Pending.Name = "lbl_Pending";
			mainDialogWindow.lbl_Pending.Size = new System.Drawing.Size(17, 13);
			mainDialogWindow.lbl_Pending.TabIndex = 20;
			mainDialogWindow.lbl_Pending.Text = "Pending:";

			mainDialogWindow.lbl_Selected.AutoSize = true;
			mainDialogWindow.lbl_Selected.Location = new System.Drawing.Point(12, 57);
			mainDialogWindow.lbl_Selected.Name = "lbl_Selected";
			mainDialogWindow.lbl_Selected.Size = new System.Drawing.Size(17, 13);
			mainDialogWindow.lbl_Selected.TabIndex = 21;
			mainDialogWindow.lbl_Selected.Text = "Selected:";

			mainDialogWindow.cb_XezzMode.AutoSize = true;
			mainDialogWindow.cb_XezzMode.Location = new System.Drawing.Point(164, 31);
			mainDialogWindow.cb_XezzMode.Name = "cb_XezzMode";
			mainDialogWindow.cb_XezzMode.Size = new System.Drawing.Size(42, 17);
			mainDialogWindow.cb_XezzMode.TabIndex = 22;
			mainDialogWindow.cb_XezzMode.Text = "XezzMode";
			mainDialogWindow.cb_XezzMode.UseVisualStyleBackColor = true;

			mainDialogWindow.ClientSize = new System.Drawing.Size(264, 79);
		}

		private void btn_Layout3_Click(object sender, EventArgs e)
		{
			mainDialogWindow.btn_left.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			mainDialogWindow.btn_left.Location = new System.Drawing.Point(56, 25);
			mainDialogWindow.btn_left.Name = "btn_left";
			mainDialogWindow.btn_left.Size = new System.Drawing.Size(18, 23);
			mainDialogWindow.btn_left.TabIndex = 13;
			mainDialogWindow.btn_left.Text = "<";
			mainDialogWindow.btn_left.UseVisualStyleBackColor = true;
			
			mainDialogWindow.btn_right.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			mainDialogWindow.btn_right.Location = new System.Drawing.Point(80, 25);
			mainDialogWindow.btn_right.Name = "btn_right";
			mainDialogWindow.btn_right.Size = new System.Drawing.Size(18, 23);
			mainDialogWindow.btn_right.TabIndex = 14;
			mainDialogWindow.btn_right.Text = ">";
			mainDialogWindow.btn_right.UseVisualStyleBackColor = true;

			mainDialogWindow.btn_inv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			mainDialogWindow.btn_inv.Location = new System.Drawing.Point(56, 51);
			mainDialogWindow.btn_inv.Name = "btn_inv";
			mainDialogWindow.btn_inv.Size = new System.Drawing.Size(18, 23);
			mainDialogWindow.btn_inv.TabIndex = 15;
			mainDialogWindow.btn_inv.Text = "i";
			mainDialogWindow.btn_inv.UseVisualStyleBackColor = true;

			mainDialogWindow.btn_remove.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			mainDialogWindow.btn_remove.Location = new System.Drawing.Point(80, 51);
			mainDialogWindow.btn_remove.Name = "btn_remove";
			mainDialogWindow.btn_remove.Size = new System.Drawing.Size(18, 23);
			mainDialogWindow.btn_remove.TabIndex = 16;
			mainDialogWindow.btn_remove.Text = "r";
			mainDialogWindow.btn_remove.UseVisualStyleBackColor = true;

			mainDialogWindow.lbl_requestCount.AutoSize = true;
			mainDialogWindow.lbl_requestCount.Location = new System.Drawing.Point(35, 30);
			mainDialogWindow.lbl_requestCount.Name = "lbl_requestCount";
			mainDialogWindow.lbl_requestCount.Size = new System.Drawing.Size(13, 13);
			mainDialogWindow.lbl_requestCount.TabIndex = 17;
			mainDialogWindow.lbl_requestCount.Text = "0";

			mainDialogWindow.lbl_currentNr.AutoSize = true;
			mainDialogWindow.lbl_currentNr.Location = new System.Drawing.Point(35, 57);
			mainDialogWindow.lbl_currentNr.Name = "lbl_currentNr";
			mainDialogWindow.lbl_currentNr.Size = new System.Drawing.Size(13, 13);
			mainDialogWindow.lbl_currentNr.TabIndex = 18;
			mainDialogWindow.lbl_currentNr.Text = "0";
			
			mainDialogWindow.lbl_currentName.AutoSize = true;
			mainDialogWindow.lbl_currentName.Location = new System.Drawing.Point(65, 6);
			mainDialogWindow.lbl_currentName.Name = "lbl_currentName";
			mainDialogWindow.lbl_currentName.Size = new System.Drawing.Size(33, 13);
			mainDialogWindow.lbl_currentName.TabIndex = 19;
			mainDialogWindow.lbl_currentName.Text = "None";
			
			mainDialogWindow.lbl_Pending.AutoSize = true;
			mainDialogWindow.lbl_Pending.Location = new System.Drawing.Point(12, 30);
			mainDialogWindow.lbl_Pending.Name = "lbl_Pending";
			mainDialogWindow.lbl_Pending.Size = new System.Drawing.Size(17, 13);
			mainDialogWindow.lbl_Pending.TabIndex = 20;
			mainDialogWindow.lbl_Pending.Text = "P:";

			mainDialogWindow.lbl_Selected.AutoSize = true;
			mainDialogWindow.lbl_Selected.Location = new System.Drawing.Point(12, 57);
			mainDialogWindow.lbl_Selected.Name = "lbl_Selected";
			mainDialogWindow.lbl_Selected.Size = new System.Drawing.Size(17, 13);
			mainDialogWindow.lbl_Selected.TabIndex = 21;
			mainDialogWindow.lbl_Selected.Text = "S:";
			
			mainDialogWindow.cb_XezzMode.AutoSize = true;
			mainDialogWindow.cb_XezzMode.Location = new System.Drawing.Point(100, 41);
			mainDialogWindow.cb_XezzMode.Name = "cb_XezzMode";
			mainDialogWindow.cb_XezzMode.Size = new System.Drawing.Size(42, 17);
			mainDialogWindow.cb_XezzMode.TabIndex = 22;
			mainDialogWindow.cb_XezzMode.Text = "XM";
			mainDialogWindow.cb_XezzMode.UseVisualStyleBackColor = true;

			mainDialogWindow.ClientSize = new System.Drawing.Size(165, 78);
		}

		private void btn_ShowHideTitleBar_Click(object sender, EventArgs e)
		{
			if (mainDialogWindow.FormBorderStyle != System.Windows.Forms.FormBorderStyle.None)
			{
				mainDialogWindow.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			}
			else
			{
				mainDialogWindow.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
			}
		}

		private void btn_ExitApp_Click(object sender, EventArgs e)
		{
			mainDialogWindow.Close();
		}

		private void btn_ResetWindowPos_Click(object sender, EventArgs e)
		{
			mainDialogWindow.Location = new Point(0, 0);
		}

		private void btn_SetWindowPos_Click(object sender, EventArgs e)
		{
			int valueX;
			int valueY;

			var text = tb_WindowPosX.Text;
			bool isNumericX = int.TryParse(text, out valueX);

			text = tb_WindowPosY.Text;
			bool isNumericY = int.TryParse(text, out valueY);

			if (isNumericX && isNumericY)
			{
				Point newPoint = new Point(valueX, valueY);
				mainDialogWindow.Location = newPoint;
			}
		}

		private void btn_ShowHideXezzModeButton_Click(object sender, EventArgs e)
		{
			if (mainDialogWindow.cb_XezzMode.Visible)
			{
				mainDialogWindow.cb_XezzMode.Visible = false;
			}
			else
			{
				mainDialogWindow.cb_XezzMode.Visible = true;
			}
		}
	}
}
