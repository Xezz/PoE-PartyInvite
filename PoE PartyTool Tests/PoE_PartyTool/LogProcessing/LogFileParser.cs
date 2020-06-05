using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoE_PartyTool.LogProcessing
{
	public class LogFileParser
	{
		public string ParseLine(string line)
		{
			return line.Replace(" ", "_");
		}
	}
}
