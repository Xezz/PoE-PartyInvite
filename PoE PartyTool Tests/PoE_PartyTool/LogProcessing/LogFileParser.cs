namespace PoE_PartyTool.LogProcessing
{
	public class LogFileParser
	{
		public string ParseLine(string line)
		{
			if (string.IsNullOrEmpty(line)) return "";

			var lineIndex = line.IndexOf("&");
			if (lineIndex == 54)
            {
                string nameBisEnde = line.Substring(lineIndex + 7);
				var doppelpunktIndex = nameBisEnde.IndexOf(":");
				string name = nameBisEnde.Substring(0, doppelpunktIndex);
				string chatmessage = nameBisEnde.Substring(doppelpunktIndex);
				if (chatmessage.ToLower().Contains("!inv"))
                {
					return name;
                }
            }

			return "";
		}
	}
}
