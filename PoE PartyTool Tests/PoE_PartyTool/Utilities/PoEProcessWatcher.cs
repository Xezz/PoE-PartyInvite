using System;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Management;

namespace PoE_PartyTool.Utilities
{
	public enum PoEWindowState
	{
		WINDOW_ACTIVE = 1,
		WINDOW_INACTIVE = 2,
		NOT_FOUND = 404
	}

	public class PoEProcessWatcher
	{
		[DllImport("user32.dll")]
		public static extern IntPtr GetWindowThreadProcessId(IntPtr hWnd, out uint ProcessId);

		[DllImport("user32.dll")]
		private static extern IntPtr GetForegroundWindow();

		public Process[] localByName;

		public int PoEProcessID = 0;
		public string PoEProcessPath = "";

		public PoEWindowState GetPoEWindowState()
		{
			if (PoEProcessPath != "")
			{
				// Get currently active(focused) process
				uint activeProcId = GetActiveProcessFileName();

				// Check active process if it is PoE
				if (activeProcId == PoEProcessID)
				{
					// PoE running and in focus
					return PoEWindowState.WINDOW_ACTIVE;
				}
				else
				{
					// PoE not in focus
					return PoEWindowState.WINDOW_INACTIVE;
				}
			}
			else
			{
				return PoEWindowState.NOT_FOUND;
			}
		}

		internal void UpdateProcessPath()
		{
			localByName = Process.GetProcesses().Where(x => x.ProcessName.ToLower().StartsWith("pathofexile")).ToArray();

			if (localByName.Length >= 1)
			{
				PoEProcessID = localByName[0].Id;
				PoEProcessPath = ProcessExecutablePath(localByName[0]);
			}
			else
			{
				PoEProcessID = 0;
				PoEProcessPath = "";
			}
		}

		internal bool IsProcessPathSet()
		{
			return PoEProcessPath != null && PoEProcessPath.EndsWith(".exe");
		}

		private uint GetActiveProcessFileName()
		{
			IntPtr hwnd = GetForegroundWindow();
			uint pid;
			GetWindowThreadProcessId(hwnd, out pid);

			return pid;
		}

		public string ProcessExecutablePath(Process process)
		{
			try
			{
				return process.MainModule.FileName;
			}
			catch
			{
				string query = "SELECT ExecutablePath, ProcessID FROM Win32_Process";
				ManagementObjectSearcher searcher = new ManagementObjectSearcher(query);

				foreach (ManagementObject item in searcher.Get())
				{
					object id = item["ProcessID"];
					object path = item["ExecutablePath"];

					if (path != null && id.ToString() == process.Id.ToString())
					{
						return path.ToString();
					}
				}
			}

			return "";
		}
	}
}
