using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace PoE_PartyTool.Utilities
{
	public enum PoEWindowState
	{
		WINDOW_ACTIVE = 1,
		WINDOW_INACTIVE = 2,
		NOT_FOUND = 404
	}

	class PoEProcessWatcher
	{
		[DllImport("user32.dll")]
		public static extern IntPtr GetWindowThreadProcessId(IntPtr hWnd, out uint ProcessId);

		[DllImport("user32.dll")]
		private static extern IntPtr GetForegroundWindow();

		public PoEProcessWatcher()
		{
				
		}

		public PoEWindowState GetPoEWindowState()
		{
			// Get the PoE process
			Process[] localByName = Process.GetProcesses().Where(x => x.ProcessName.ToLower().StartsWith("pathofexile")).ToArray(); // this only works in case the PoE process starts with "PathOfExile". in case the exe has been renamed in some other way, this wont work

			if (localByName.Length >= 1)
			{
				// Store the PoE process ID
				int PoEID = localByName[0].Id;
				// Get currently active(focused) process
				uint activeProcId = GetActiveProcessFileName();

				// Check active process if it is PoE
				if (activeProcId == PoEID)
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

		uint GetActiveProcessFileName()
		{
			IntPtr hwnd = GetForegroundWindow();
			uint pid;
			GetWindowThreadProcessId(hwnd, out pid);

			return pid;
		}
	}
}
