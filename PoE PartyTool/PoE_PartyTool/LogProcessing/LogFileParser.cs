using PoE_PartyTool.PoE_PartyTool.Executors;
using PoE_PartyTool.PoE_PartyTool.Model;
using System;
using System.Text.RegularExpressions;

namespace PoE_PartyTool.LogProcessing
{
    public class LogFileParser
    {
        private static readonly Regex regex = new Regex(@"(\d{4}\/\d{2}\/\d{2} \d{2}:\d{2}:\d{2}) \d{1,} [a-zA-Z0-9]{1,} \[.*\] (&|#|@From |\$)(<.*> ){0,1}([^\s]+): (.+)");

        public PartyRequest ParseLine(string line)
        {
            Match match = regex.Match(line);

            if (match.Success)
            {
                return new PartyRequest(
                    executor: new InviteExecutor(),
                    requestDate: DateTime.Parse(match.Groups[1].Captures[0].Value), // Year/Month/Day Hour:Minute:Seconds
                    requestSource: RequestSourceBuilder.FromString(match.Groups[2].Captures[0].Value),
                    guildName: match.Groups[3].Length > 1 ? match.Groups[3].Captures[0].Value.Trim() : string.Empty,
                    characterName: match.Groups[4].Captures[0].Value,
                    requestMessage: match.Groups[5].Captures[0].Value
                );
            }

            return null;

        } // ParseLine

        /*
         * funktioniert auf der seite: https://regex101.com/ 
         * (\d{4})\/(\d{2})\/(\d{2}) (\d{2}):(\d{2}):(\d{2}) \d{9} [a-zA-Z0-9]{2,3} \[.*\] (&|#|@From |\$)(<.*> ){0,1}(.*): (.*)
         * (\d{4})/(\d{2})/(\d{2}) (\d{2}):(\d{2}):(\d{2}) \d{9} [a-zA-Z0-9]{2,3} \[.*\] (&|@From |#)(<.*> ){0,1}(.*): (.*)
         * The regex above did no longer match the lines that are added to the client.txt file
         * 
         * This regex did match the log lines added (2022-12-08)
         * (\d{4}\/\d{2}\/\d{2} \d{2}:\d{2}:\d{2}) \d{1,} [a-zA-Z0-9]{1,} \[.*\] (&|#|@From |\$)(<.*> ){0,1}([^\s]+): (.+)
         * 
         */
    }
}
