using PoE_PartyTool_Tests.PoE_PartyTool.Executors;
using PoE_PartyTool_Tests.PoE_PartyTool.Model;
using System;
using System.Text.RegularExpressions;

namespace PoE_PartyTool.LogProcessing
{
	public class LogFileParser
	{
        private static readonly Regex regex = new Regex(@"(\d{4}\/\d{2}\/\d{2} \d{2}:\d{2}:\d{2}) \d{9,} [a-zA-Z0-9]{2,3} \[.*\] (&|#|@From |\$)(<.*> ){0,1}([^\s]+): (.+)");

        public PartyRequest ParseLine(string line)
		{
            Match match = regex.Match(line);
            PartyRequest result = null;
            if (match.Success)
            {
                /**
                 * 1 Year/Month/Day Hour:Minute:Seconds
                 * 2 Source
                 * 3 Guild (maybe null)
                 * 4 Character
                 * 5 Message
                 * */
                result = new PartyRequest(new InviteExecutor());
                if (match.Groups[3].Length > 1)
                {
                    result.GuildName = match.Groups[3].Captures[0].Value.Trim();
                }
                else
                {
                    result.GuildName = "";
                }
                result.CharacterName = match.Groups[4].Captures[0].Value;
                result.RequestDate = DateTime.Parse(match.Groups[1].Captures[0].Value);
                result.RequestSource = RequestSourceBuilder.FromString(match.Groups[2].Captures[0].Value);
                result.RequestMessage = match.Groups[5].Captures[0].Value;
            }
            return result;
        }

        /*
         * funktioniert auf der seite: https://regex101.com/ 
         * (\d{4})\/(\d{2})\/(\d{2}) (\d{2}):(\d{2}):(\d{2}) \d{9} [a-zA-Z0-9]{2,3} \[.*\] (&|#|@From |\$)(<.*> ){0,1}(.*): (.*)
         * (\d{4})/(\d{2})/(\d{2}) (\d{2}):(\d{2}):(\d{2}) \d{9} [a-zA-Z0-9]{2,3} \[.*\] (&|@From |#)(<.*> ){0,1}(.*): (.*)
         * 
         */
    }
}
