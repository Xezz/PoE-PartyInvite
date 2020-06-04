using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MiscUtil.IO; // ReverseLineReader

namespace PoE_PartyTool.LogProcessing
{
	class LogFileReader
	{
		public string ReadLastLineFromLogFile()
		{
			using (Stream stream = File.Open(@"D:\Programme\SteamD\steamapps\common\Path of Exile\logs\Client.txt", FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
			{
				ReverseLineReader line = new ReverseLineReader(() => stream); // create anonymous method to return Stream as Func<Stream>

				var last = line.Take(1);

				return string.Join(" ", last.ToArray());
			}
		}
	}
}
