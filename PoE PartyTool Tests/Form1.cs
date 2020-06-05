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
		// Todo Dependency Injection
		PoEProcessWatcher processWatcher = new PoEProcessWatcher();
		LogFileReader logReader = new LogFileReader();
		LogFileParser logParser = new LogFileParser();

		private bool isProcessPathSet = false;
		private bool isCharacterNameSet = false;
		private bool isLogPathSet = false;

		private Timer startupTimer = new Timer();
		private Timer keepAlive = new Timer();

		private Timer debugTimer = new Timer();

		public Form1()
		{
			InitializeComponent();

			logReader.logFilePath = processWatcher.PoEProcessPath;

			InitTimers();
		}

		private void InitTimers()
		{
			startupTimer.Tick += new EventHandler(OnTimedEvent_GetStartupEssencials);
			startupTimer.Enabled = false;
			startupTimer.Interval = 1000;
			StartTimer(startupTimer);

			keepAlive.Tick += new EventHandler(OnTimedEvent_GetProcessAliveState);
			keepAlive.Enabled = false;
			keepAlive.Interval = 5000;
			StartTimer(keepAlive);

			debugTimer.Tick += new EventHandler(OnTimedEvent_DebugTimerMethod);
			debugTimer.Enabled = false;
			debugTimer.Interval = 1000;
			StopTimer(debugTimer);
		}

		/// <summary>
		/// Get PoE Process Path
		/// Get logged character name
		/// Get log file path
		/// </summary>
		/// <param name="source"></param>
		/// <param name="myEventArgs"></param>
		private void OnTimedEvent_GetStartupEssencials(Object source, EventArgs myEventArgs)
		{
			PoEWindowState state = processWatcher.GetPoEWindowState();

			if (state == PoEWindowState.NOT_FOUND)
			{
				processWatcher.UpdateProcessPath();
				state = processWatcher.GetPoEWindowState();

				if (state == PoEWindowState.NOT_FOUND)
				{
					return;
				}
			}

			if (state == PoEWindowState.WINDOW_ACTIVE || state == PoEWindowState.WINDOW_INACTIVE)
			{
				//lbl_PoEFocus.Text = "PoE Active!";
				if (isProcessPathSet == false)
				{
					if (processWatcher.PoEProcessPath != "" && processWatcher.PoEProcessPath.EndsWith(".exe"))
					{
						isProcessPathSet = true;
					}
					else
					{
						processWatcher.UpdateProcessPath();
					}
				}

				if (isProcessPathSet == true && isLogPathSet == false)
				{
					if (logReader.logFilePath.EndsWith("logs\\Client.txt"))
					{
						isLogPathSet = true;
					}
					else
					{
						logReader.UpdateLogFilePath(processWatcher.PoEProcessPath);
					}
				}

				// Todo: Add isCharacterNameSet checks
			}
			else if (state == PoEWindowState.NOT_FOUND)
			{
				lbl_PoEFocus.Text = "Process could not be found!";
			}
		}

		private void OnTimedEvent_GetProcessAliveState(Object source, EventArgs myEventArgs)
		{
			processWatcher.UpdateProcessPath();
			logReader.UpdateLogFilePath(processWatcher.PoEProcessPath);
		}

		private void StartTimer(Timer timer)
		{
			timer.Start();
			timer.Enabled = true;
		}

		private void StopTimer(Timer timer)
		{
			timer.Stop();
			timer.Enabled = false;
		}

		private void OnTimedEvent_DebugTimerMethod(Object source, EventArgs myEventArgs)
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
				if (debugTimer.Enabled == false)
				{
					StartTimer(debugTimer);
				}
			}
			else
			{
				btn_CheckFocus.Enabled = true;

				if (debugTimer.Enabled == true)
				{
					StopTimer(debugTimer);
				}
			}
		}
	}
}
