using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using PoE_PartyTool.Utilities;

namespace PoE_PartyTool.LogProcessing
{
	public class LogFileReader
	{
		private string lastKnownLine;
		private string _logFilePath;

        public LogFileReader(string processPath)
        {
			if (!string.IsNullOrEmpty(processPath))
			{
				int lastIndex = processPath.LastIndexOf("\\");
				if (lastIndex >= 0)
                {
                    _logFilePath = processPath.Substring(0, lastIndex) + "\\logs\\Client.txt";
                }
			}
		}

        public IEnumerable<string> GetLinesSinceLastKnownLine()
		{
			if (!string.IsNullOrEmpty(_logFilePath))
			{
				using (Stream stream = File.Open(_logFilePath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
				{
					if (stream != null)
					{
						ReverseLineReader line = new ReverseLineReader(() => stream); // create anonymous method to return Stream as Func<Stream>

                        if (string.IsNullOrEmpty(lastKnownLine))
                        {
							var latestLine = line.Take(1).ToList();
							lastKnownLine = latestLine.First();
							return latestLine;
						}
                        var newChatLines = line.Take(15).ToList();
						var indexOfLastKnownLine = newChatLines.IndexOf(lastKnownLine);
						lastKnownLine = newChatLines.First();
						if (indexOfLastKnownLine >= 0)
						{
                            return newChatLines.Take(indexOfLastKnownLine);
						}

						return newChatLines;
					}
				}
			}

			return new List<string>{ "404 -> Logfile not found!" };
		}

		public bool IsLogFilePathSet()
		{
			return !string.IsNullOrEmpty(_logFilePath) && _logFilePath.EndsWith("logs\\Client.txt");
		}
	}
}
