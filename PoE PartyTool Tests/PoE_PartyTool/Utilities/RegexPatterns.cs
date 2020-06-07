using PoE_PartyTool_Tests.PoE_PartyTool.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PoE_PartyTool_Tests.PoE_PartyTool.Utilities
{
    
    public class RegexPatterns
    {
        public static string DatePattern = @"(\d{4})\/(\/d{2})\/(\/{2})"; // evtl (\\d{4})\\/(\d{2})\\/(\d{2})
        public static string TimePattern = @"(\d{2}):(\d{2}):(\d{2})";
        public static string TimestampPattern = @"\d{9}";
        public static string IntermediatedPattern = @"[a-zA-Z0-9]{2,3}";
        public static string ClientInfoPattern = @"\[.*\]";
        public static string ChannelPattern = @"(&|@From |#)";
        public static string GuildOrNonePattern = @"(<.*> ){0,1}";
        public static string CharacterNamePattern = @"(.*)";
        public static string ColonPattern = @": ";
        public static string MessagePattern = @"(.*)";
        public static string TheRealRegEx = @DatePattern + " " + TimePattern + " " + TimestampPattern
            + " " + IntermediatedPattern + " " + ClientInfoPattern + " " + ChannelPattern + GuildOrNonePattern
            + CharacterNamePattern + ColonPattern + MessagePattern;

        public static PartyRequest Matchregex(string line)
        {
            //Regex regex = new Regex(TheRealRegEx);
            Regex regex = new Regex(@"(\d{4})\/(\d{2})\/(\d{2}) (\d{2}):(\d{2}):(\d{2}) \d{9} [a-zA-Z0-9]{2,3} \[.*\] (&|#|@From |\$)(<.*> ){0,1}([^\s]+): (.+)");
            Match match = regex.Match(line);
            PartyRequest result = null;
            if (match.Success)
            {
                /*
                 * 1 Year
                 * 2 Month
                 * 3 Day
                 * 4 Hour
                 * 5 Minute
                 * 6 Seconds
                 * 7 Source
                 * 8 Guild (maybe null)
                 * 9 Character
                 * 10 Message
                 * */
                result = new PartyRequest();
                result.GuildName = match.Groups[8].Captures[0].Value;
                int year = Int32.Parse(match.Groups[1].Captures[0].Value);
                int month = Int32.Parse(match.Groups[2].Captures[0].Value);
                int day = Int32.Parse(match.Groups[3].Captures[0].Value);
                int hour = Int32.Parse(match.Groups[4].Captures[0].Value);
                int minute = Int32.Parse(match.Groups[5].Captures[0].Value);
                int second = Int32.Parse(match.Groups[6].Captures[0].Value);
                DateTime messageTime = new DateTime(year, month, day, hour, minute, second);
                string source = match.Groups[7].Captures[0].Value;
                string character = match.Groups[9].Captures[0].Value;
                string message = match.Groups[10].Captures[0].Value;
                result.CharacterName = character;
                result.RequestDate = messageTime;
                result.RequestSource = RequestSourceBuilder.FromString(source);
                result.RequestMessage = message;
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
