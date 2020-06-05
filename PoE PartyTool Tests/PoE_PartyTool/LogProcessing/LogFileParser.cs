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
