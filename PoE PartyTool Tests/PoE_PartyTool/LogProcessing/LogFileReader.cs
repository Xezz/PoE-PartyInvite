using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MiscUtil.IO; // ReverseLineReader

using System.Configuration;
using System.Collections.Specialized;

namespace PoE_PartyTool.LogProcessing
{
	class LogFileReader
	{
		public string logFilePath { get; set; }

		public LogFileReader()
		{

		}

		public string ReadLastLineFromLogFile()
		{
			if (logFilePath.Length > 0)
			{
				using (Stream stream = File.Open(logFilePath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
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
			if (processPath != "")
			{
				string[] path = processPath.Split('\\');
				int len = path.Length;

				string p2 = "";

				for (int i = 0; i < len - 1; i++)
				{
					p2 += path[i].ToString();
					p2 += "\\";
				}

				p2 += "logs\\Client.txt";

				logFilePath = p2;
			}
			else
			{
				logFilePath = "";
			}
		}
	}
}
