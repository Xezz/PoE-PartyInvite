using System;
using System.Windows.Forms;

using PoE_PartyTool.Utilities;
using PoE_PartyTool.LogProcessing;
using PoE_PartyTool_Tests.PoE_PartyTool.Executors;
using System.Runtime.InteropServices;

namespace PoE_PartyTool_Tests
{
	public partial class PartyInviteUI : Form
	{
		// Todo Dependency Injection
		PoEProcessWatcher processWatcher;
		LogFileReader logReader;
		LogFileParser logParser;

		private Timer runtimeCheckTimer = new Timer();
		private Timer checkRegularlyLogAndSendMessageTimer = new Timer();
		private Timer debugTimer = new Timer(); //Todo: this timer can be removed at some point, just used for testing reasons

		public PartyInviteUI()
		{			
			InitializeComponent();
			Init();
		}

		private void Init()
		{
			processWatcher = new PoEProcessWatcher();
			logParser = new LogFileParser();
			logReader = new LogFileReader(processWatcher.PoEProcessPath);

			InitTimers();
		}

		private void InitTimers()
		{
			runtimeCheckTimer.Tick += new EventHandler(OnTimedEvent_CheckAndUpdateProcessState);
			runtimeCheckTimer.Enabled = false;
			runtimeCheckTimer.Interval = 1000;
			StartTimer(runtimeCheckTimer);
			
			checkRegularlyLogAndSendMessageTimer.Tick += new EventHandler(OnTimedEvent_ReadLogAndMessage);
			checkRegularlyLogAndSendMessageTimer.Enabled = false;
			checkRegularlyLogAndSendMessageTimer.Interval = 250;			
			StartTimer(checkRegularlyLogAndSendMessageTimer);

			//Todo: this timer can be removed at some point, just used for testing reasons
			debugTimer.Tick += new EventHandler(OnTimedEvent_DebugTimerMethod);
			debugTimer.Enabled = false;
			debugTimer.Interval = 1000;
			StartTimer(debugTimer);
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

		//Todo: this timer can be removed at some point, just used for testing reasons
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

		//Todo: debuging with this button does no longer work, the logParser returns "" in case a non command is found -> remove this debug functionality or edit it to work again
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

		private void cb_AutoFocusCheck_CheckedChanged(object sender, EventArgs e)
		{
			if (cb_AutoFocusCheck.CheckState == CheckState.Checked)
			{				
				if (debugTimer.Enabled == false)
				{
					StartTimer(debugTimer);
				}
			}
			else
			{
				if (debugTimer.Enabled == true)
				{
					StopTimer(debugTimer);
				}
			}
		}

		private void cb_ForceToForeground_CheckedChanged(object sender, EventArgs e)
		{
			if (cb_ForceToForeground.Checked)
			{
				this.TopMost = true;
			}
			else
			{
				this.TopMost = false;
			}
		}
	}
}