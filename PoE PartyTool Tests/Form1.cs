using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using System.Runtime.InteropServices;


using PoE_PartyTool.Utilities;
using PoE_PartyTool.LogProcessing;

namespace PoE_PartyTool_Tests
{
	public partial class Form1 : Form
	{
		PoEProcessWatcher processWatcher = new PoEProcessWatcher();
		LogFileReader logReader = new LogFileReader();
		LogFileParser logParser = new LogFileParser();
			   
		private Timer aTimer = new Timer();

		public Form1()
		{
			InitializeComponent();

			InitTimer();			
		}

		private void InitTimer()
		{
			aTimer.Tick += new EventHandler(OnTimedEvent);
			aTimer.Enabled = false;
			aTimer.Interval = 1000;

			StopTimer();
		}

		private void OnTimedEvent(Object source, EventArgs myEventArgs)
		{
			if (processWatcher.GetPoEWindowState() == PoEWindowState.WINDOW_ACTIVE)
			{
				lbl_PoEFocus.Text = "PoE Active!";
			}
			else if (processWatcher.GetPoEWindowState() == PoEWindowState.WINDOW_INACTIVE)
			{
				lbl_PoEFocus.Text = "PoE Inactive!";
			}
			else if (processWatcher.GetPoEWindowState() == PoEWindowState.NOT_FOUND)
			{
				lbl_PoEFocus.Text = "Process could not be found!";
			}
		}

		private void StartTimer()
		{
			aTimer.Start();
			aTimer.Enabled = true;
		}

		private void StopTimer()
		{
			aTimer.Stop();
			aTimer.Enabled = false;
		}		

		private void btn_ReadLine_Click(object sender, EventArgs e)
		{
			var lastLine = logReader.ReadLastLineFromLogFile();
			lbl_LastLine.Text = logParser.ParseLine(lastLine);
		}

		private void btn_CheckFocus_Click(object sender, EventArgs e)
		{
			if (processWatcher.GetPoEWindowState() == PoEWindowState.WINDOW_ACTIVE)
			{
				lbl_PoEFocus.Text = "PoE Active!";
			}
			else if (processWatcher.GetPoEWindowState() == PoEWindowState.WINDOW_INACTIVE)
			{
				lbl_PoEFocus.Text = "PoE Inactive!";
			}
			else if (processWatcher.GetPoEWindowState() == PoEWindowState.NOT_FOUND)
			{
				lbl_PoEFocus.Text = "Process could not be found!";
			}
		}

		private void cb_AutoFocusCheck_CheckedChanged(object sender, EventArgs e)
		{
			if (cb_AutoFocusCheck.CheckState == CheckState.Checked)
			{
				btn_CheckFocus.Enabled = false;
				if (aTimer.Enabled == false)
				{
					StartTimer();
				}
			}
			else
			{
				btn_CheckFocus.Enabled = true;

				if (aTimer.Enabled == true)
				{
					StopTimer();
				}
			}
		}
	}
}
