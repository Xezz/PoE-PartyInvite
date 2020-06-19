using System;
using System.Windows.Forms;


using PoE_PartyTool.Utilities;
using PoE_PartyTool.LogProcessing;
using PoE_PartyTool_Tests.PoE_PartyTool.Executors;
using System.Collections.Generic;

namespace PoE_PartyTool_Tests
{
	public partial class Form1 : Form
	{
		// Todo Dependency Injection
		PoEProcessWatcher processWatcher;
		LogFileReader logReader;
		LogFileParser logParser;

		private Timer runtimeCheckTimer = new Timer();
		private Timer checkRegularlyLogAndSendMessageTimer = new Timer();
		private Timer debugTimer = new Timer(); //Todo: this timer can be removed at some point, just used for testing reasons

		private ToolTip xezzModeToolTip = new ToolTip();

		private List<PoE_PartyTool.Model.PartyRequest> requestList;

		private int selectedListItem = 0;

		public Form1()
		{			
			InitializeComponent();

			Init();
		}

		private void Init()
		{
			processWatcher = new PoEProcessWatcher();
			logParser = new LogFileParser();
			logReader = new LogFileReader(processWatcher.PoEProcessPath);

			xezzModeToolTip.SetToolTip(cb_XezzMode, "Enabling this could get you BANNED! Use at OWN RISK!");
			requestList = new List<PoE_PartyTool.Model.PartyRequest>();

			this.TopMost = true;

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
			StopTimer(debugTimer);
		}

        private void OnTimedEvent_ReadLogAndMessage(object sender, EventArgs e)
        {
			if (PoEWindowState.WINDOW_ACTIVE == processWatcher.GetPoEWindowState())
			{
				var latestLines = logReader.GetLinesSinceLastKnownLine();
				foreach (string line in latestLines)
				{
					var request = logParser.ParseLine(line);
					
					if (request != null )
					{
						if (request.RequestMessage.ToLower().StartsWith("!inv") && request.RequestSource == PoE_PartyTool.Model.RequestSource.GUILD)
                        {
							if (cb_XezzMode.Checked == true)
							{
								request.Execute();
							}
							else
							{
								foreach (var inList in requestList)
								{
									if (inList.CharacterName == request.CharacterName)
									{
										// there is already a request from this character present, in this case we could switch to that characters request
										return;
									}
								}

								requestList.Add(request);
								lbl_requestCount.Text = requestList.Count.ToString();

								// quick fix for if the list is empty. this way no extra timer is needed for the moment
								if (requestList.Count == 1)
								{
									selectedListItem = 0;
									lbl_currentNr.Text = (selectedListItem + 1).ToString();
									lbl_currentName.Text = requestList[selectedListItem].CharacterName;
								}
							}
                        }
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
		}

		private void trackBar1_Scroll(object sender, EventArgs e)
		{
			this.Opacity = Convert.ToDouble(slider_Opacity.Value) / 100;
		}

		private void btn_left_Click(object sender, EventArgs e)
		{
			if (requestList.Count > 0)
			{
				if (selectedListItem == 0)
				{
					selectedListItem = requestList.Count;

					lbl_currentName.Text = requestList[selectedListItem].CharacterName;
					lbl_currentNr.Text = (selectedListItem + 1).ToString();
				}
				else
				{
					selectedListItem--;

					lbl_currentName.Text = requestList[selectedListItem].CharacterName;
					lbl_currentNr.Text = (selectedListItem + 1).ToString();
				}
			}
		}

		private void btn_right_Click(object sender, EventArgs e)
		{
			if (requestList.Count > 0)
			{
				if (selectedListItem == requestList.Count)
				{
					selectedListItem = 0;

					lbl_currentName.Text = requestList[selectedListItem].CharacterName;
					lbl_currentNr.Text = (selectedListItem + 1).ToString();
				}
				else
				{
					selectedListItem++;

					lbl_currentName.Text = requestList[selectedListItem].CharacterName;
					lbl_currentNr.Text = (selectedListItem + 1).ToString();
				}
			}
		}

		private void btn_inv_Click(object sender, EventArgs e)
		{
			if (requestList.Count > 0)
			{
				if (processWatcher.SetPoEToFocusWindow())
				{
					requestList[selectedListItem].Execute();

					RemoveSelectedRequest();
				}
			}
		}

		private void btn_remove_Click(object sender, EventArgs e)
		{
			RemoveSelectedRequest();
		}

		private void RemoveSelectedRequest()
		{
			if (requestList.Count > 0)
			{
				requestList.RemoveAt(selectedListItem);
				lbl_requestCount.Text = requestList.Count.ToString();

				if (requestList.Count == 0)
				{ 
					lbl_currentName.Text = "None";
					lbl_currentNr.Text = "0";

					return;
				}

				if (selectedListItem < requestList.Count)
				{
					lbl_currentName.Text = requestList[selectedListItem].CharacterName;
				}
				else
				{
					selectedListItem = 0;
					lbl_currentName.Text = requestList[selectedListItem].CharacterName;
					lbl_currentNr.Text = (selectedListItem + 1).ToString();
				}
			}
		}
	}
}