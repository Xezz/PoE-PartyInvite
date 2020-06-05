using System.IO;
using System.Linq;
using PoE_PartyTool.Utilities;

namespace PoE_PartyTool.LogProcessing
{
	public class LogFileReader
	{
		public string LogFilePath { get; set; }

		public string ReadLastLineFromLogFile()
		{
			if (LogFilePath.Length > 0)
			{
				using (Stream stream = File.Open(LogFilePath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
				{
					if (stream != null)
					{
						ReverseLineReader line = new ReverseLineReader(() => stream); // create anonymous method to return Stream as Func<Stream>

						var last = line.Take(1);

						return string.Join(" ", last.ToArray());
					}
				}
			}

			return "404 -> Logfile not found!";
		}

		public void UpdateLogFilePath(string processPath)
		{
			if (!string.IsNullOrEmpty(processPath))
			{
				int lastIndex = processPath.LastIndexOf("\\");
				LogFilePath = processPath.Substring(0, lastIndex) + "\\logs\\Client.txt";
			}
			else
			{
				LogFilePath = "";
			}
		}

		public bool IsLogFilePathSet()
		{
			return LogFilePath.EndsWith("logs\\Client.txt");
		}
	}
}
