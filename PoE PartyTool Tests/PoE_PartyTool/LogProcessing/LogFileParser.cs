using PoE_PartyTool_Tests.PoE_PartyTool.Model;
using PoE_PartyTool_Tests.PoE_PartyTool.Utilities;

namespace PoE_PartyTool.LogProcessing
{
	public class LogFileParser
	{
		public PartyRequest ParseLine(string line)
		{
			return RegexPatterns.Matchregex(line);
		}
	}
}
