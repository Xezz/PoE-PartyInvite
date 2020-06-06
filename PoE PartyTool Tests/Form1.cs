using System;
using System.Windows.Forms;


using PoE_PartyTool.Utilities;
using PoE_PartyTool.LogProcessing;
using PoE_PartyTool_Tests.PoE_PartyTool.Executors;

namespace PoE_PartyTool_Tests
{
	public partial class Form1 : Form
	{
		// Todo Dependency Injection
		PoEProcessWatcher processWatcher = new PoEProcessWatcher();
		LogFileReader logReader;
		LogFileParser logParser;

		private bool isProcessPathSet = false;
		private bool isCharacterNameSet = false;
		private bool isLogPathSet = false;

		private Timer startupTimer = new Timer();
		private Timer keepAlive = new Timer();

		private Timer debugTimer = new Timer();

		public Form1()
		{
			logParser = new LogFileParser();
			logReader = new LogFileReader(processWatcher.PoEProcessPath);
			InitializeComponent();
			InitTimers();
		}

		private void InitTimers()
		{
			startupTimer.Tick += new EventHandler(OnTimedEvent_GetStartupEssentials);
			startupTimer.Enabled = false;
			startupTimer.Interval = 1000;
			StartTimer(startupTimer);

			keepAlive.Tick += new EventHandler(OnTimedEvent_CheckAndUpdateProcessState);
			keepAlive.Enabled = false;
			keepAlive.Interval = 5000;
			StartTimer(keepAlive);

			debugTimer.Tick += new EventHandler(OnTimedEvent_DebugTimerMethod);
			debugTimer.Enabled = false;
			debugTimer.Interval = 1000;
			StopTimer(debugTimer);

			var checkRegularlyLogAndSendMessageTimer = new Timer();
			checkRegularlyLogAndSendMessageTimer.Enabled = false;
			checkRegularlyLogAndSendMessageTimer.Interval = 250;
			checkRegularlyLogAndSendMessageTimer.Tick += new EventHandler(OnTimedEvent_ReadLogAndMessage);
			StartTimer(checkRegularlyLogAndSendMessageTimer);
		}

        private void OnTimedEvent_ReadLogAndMessage(object sender, EventArgs e)
        {
			if (PoEWindowState.WINDOW_ACTIVE == processWatcher.GetPoEWindowState())
			{
				var latestLines = logReader.GetLinesSinceLastKnownLine();
				foreach (string line in latestLines)
				{
					string parsedLine = logParser.ParseLine(line);
					
					if (!string.IsNullOrEmpty(parsedLine))
					{
						new InviteExecutor().Execute(parsedLine);
					}
				}
			}
		}

        private void OnTimedEvent_GetStartupEssentials(Object source, EventArgs myEventArgs)
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
				if (!isProcessPathSet)
				{
					if (processWatcher.IsProcessPathSet())
					{
						isProcessPathSet = true;
					}
					else
					{
						processWatcher.UpdateProcessPath();
					}
				}
				else if (!isLogPathSet)
				{
					if (logReader.IsLogFilePathSet())
					{
						isLogPathSet = true;
					}
					else
					{
						logReader = new LogFileReader(processWatcher.PoEProcessPath);
						isLogPathSet = logReader.IsLogFilePathSet();
					}
				}

				// Todo: Add isCharacterNameSet checks
			}
			else if (state == PoEWindowState.NOT_FOUND)
			{
				lbl_PoEFocus.Text = "Process could not be found!";
			}
		}

		private void OnTimedEvent_CheckAndUpdateProcessState(Object source, EventArgs myEventArgs)
		{
			if (processWatcher.UpdateProcessPath())
			{
				logReader = new LogFileReader(processWatcher.PoEProcessPath);
			}
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
			var lastLine = logReader.GetLinesSinceLastKnownLine();
			var lines = "";
			foreach(string line in lastLine)
            {
				lines += "\n" + logParser.ParseLine(line);
			}
			lbl_LastLine.Text = lines;
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
