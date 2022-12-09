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

		[DllImport("user32.dll")]
		public static extern int SetWindowLong(IntPtr hWnd, int nIndex, uint dwNewLong);

		[System.Runtime.InteropServices.DllImport("user32.dll")]
		[return: System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.Bool)]
		private static extern bool ShowWindow(IntPtr hWnd, ShowWindowEnum flags);

		[System.Runtime.InteropServices.DllImport("user32.dll")]
		private static extern int SetForegroundWindow(IntPtr hwnd);

		private enum ShowWindowEnum
		{
			Hide = 0,
			ShowNormal = 1, ShowMinimized = 2, ShowMaximized = 3,
			Maximize = 3, ShowNormalNoActivate = 4, Show = 5,
			Minimize = 6, ShowMinNoActivate = 7, ShowNoActivate = 8,
			Restore = 9, ShowDefault = 10, ForceMinimized = 11
		};

		private Process[] localByName;
		private string _poeProcessPath;
		private int _poeProcessID;
		public string PoEProcessPath { get => _poeProcessPath; set => _poeProcessPath = value; }
		public int PoEProcessID { get => _poeProcessID; set => _poeProcessID = value; }

		public PoEProcessWatcher()
		{
			UpdateProcessPath();
		}

		public PoEWindowState GetPoEWindowState()
		{
			if (!string.IsNullOrEmpty(_poeProcessPath))
			{
				uint activeProcessId = GetActiveProcessID();

				if (activeProcessId == _poeProcessID)
				{
					return PoEWindowState.WINDOW_ACTIVE;
				}
				else
				{
					return PoEWindowState.WINDOW_INACTIVE;
				}
			}
			else
			{
				return PoEWindowState.NOT_FOUND;
			}
		}

		internal bool UpdateProcessPath()
		{
			localByName = Process.GetProcesses().Where(x => x.ProcessName.ToLower().StartsWith("pathofexile")).ToArray();
			if (localByName.Length >= 1)
			{
				_poeProcessID = localByName[0].Id;
				string currentPath = ProcessExecutablePath(localByName[0]);
				bool hasPathChanged = currentPath != _poeProcessPath;
				_poeProcessPath = currentPath;

				// Todo: it would be best to look for another fix for the VulkanRenderer problem, since its not 100% clear what this fix actually does to the PoE process
				if (hasPathChanged)
				{
					VulkanRendererUIDisplayFix();
				}

				return hasPathChanged;
			}
			else
			{
				if (!string.IsNullOrEmpty(_poeProcessPath))
				{
					_poeProcessID = 0;
					_poeProcessPath = null;

					return true;
				}
				else
				{
					return false;
				}
			}
		}

		internal bool IsProcessPathSet()
		{
			return _poeProcessPath != null && _poeProcessPath.EndsWith(".exe");
		}

		private uint GetActiveProcessID()
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
				return process.MainModule.FileName; // This only works for x32 systems
			}
			catch // this works for x64 systems
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

		private void VulkanRendererUIDisplayFix()
		{
			if (localByName[0] != null)
			{
				SetWindowLong(localByName[0].MainWindowHandle, -16, 0x10000000);
			}
		}

		public bool SetPoEToFocusWindow()
		{
			// check if the process is running
			if (localByName[0] != null)
			{
				// check if the window is hidden / minimized
				if (localByName[0].MainWindowHandle == IntPtr.Zero)
				{
					// the window is hidden so try to restore it before setting focus.
					ShowWindow(localByName[0].Handle, ShowWindowEnum.Restore);
				}

				// set user the focus to the window
				SetForegroundWindow(localByName[0].MainWindowHandle);

				return true;
			}

			return false;
		}
	}
}
