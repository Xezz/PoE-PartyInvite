using FluentAssertions;
using PoE_PartyTool.LogProcessing;
using PoE_PartyTool.PoE_PartyTool.Executors;
using PoE_PartyTool.PoE_PartyTool.Model;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Poe_PartyTool_Test.PoE_PartyTool.LogProcessing
{
    public class LogFileParserTest
    {
        [Fact]
        public void lineWithTwoSpaces_ParseLine_AllWhiteSpacesReplacedWithUnderscores()
        {
            var fileParser = new LogFileParser();
            var actual = fileParser.ParseLine("Line to parse");
            Assert.Null(actual);
        }
        [Fact]
        public void GuildChatPartyRequest_map_properPartyRequest()
        {
            string line = "2020/06/06 09:53:54 399269953 acf [INFO Client 12872] &<#TDE> GSF_HeadHeralding: !inv";
            var expected = new PartyRequest(new InviteExecutor())
            {
                CharacterName = "GSF_HeadHeralding",
                GuildName = "<#TDE>",
                RequestMessage = "!inv",
                RequestSource = RequestSource.GUILD,
                RequestDate = new DateTime(2020, 6, 6, 9, 53, 54)
            };

            PartyRequest request = new LogFileParser().ParseLine(line);

            request.Should().BeEquivalentTo(expected);
        }

        [Fact]
        public void TradeChatPartyRequest_map_properPartyRequest()
        {
            string line = "2020/06/06 09:53:54 399269953 acf [INFO Client 12872] $<#TDE> GSF_HeadHeralding: !inv";
            var expected = new PartyRequest(new InviteExecutor())
            {
                CharacterName = "GSF_HeadHeralding",
                GuildName = "<#TDE>",
                RequestMessage = "!inv",
                RequestSource = RequestSource.TRADE,
                RequestDate = new DateTime(2020, 6, 6, 9, 53, 54)
            };

            PartyRequest request = new LogFileParser().ParseLine(line);

            request.Should().BeEquivalentTo(expected);
        }

        [Fact]
        public void GlobalChatPartyRequest_map_properPartyRequest()
        {
            string line = "2020/06/29 09:53:54 399269953 acf [INFO Client 12872] #<#TDE> GSF_HeadHeralding: !inv";
            var expected = new PartyRequest(new InviteExecutor())
            {
                CharacterName = "GSF_HeadHeralding",
                GuildName = "<#TDE>",
                RequestMessage = "!inv",
                RequestSource = RequestSource.GLOBAL,
                RequestDate = new DateTime(2020, 6, 29, 9, 53, 54)
            };

            PartyRequest request = new LogFileParser().ParseLine(line);

            request.Should().BeEquivalentTo(expected);
        }

        [Fact]
        public void WhisperPartyRequest_map_properPartyRequest()
        {
            string line = "2020/06/06 09:53:54 399269953 acf [INFO Client 12872] @From <#TDE> GSF_HeadHeralding: !inv";

            var expected = new PartyRequest(new InviteExecutor())
            {
                CharacterName = "GSF_HeadHeralding",
                GuildName = "<#TDE>",
                RequestMessage = "!inv",
                RequestSource = RequestSource.WHISPER,
                RequestDate = new DateTime(2020, 6, 6, 9, 53, 54)
            };

            PartyRequest request = new LogFileParser().ParseLine(line);

            request.Should().BeEquivalentTo(expected);
        }

        [Fact]
        public void WhisperPartyRequestOhneGilde_map_properPartyRequest()
        {
            string line = "2020/06/06 09:53:54 399269953 acf [INFO Client 12872] @From GSF_HeadHeralding: !inv 1234";

            var expected = new PartyRequest(new InviteExecutor())
            {
                CharacterName = "GSF_HeadHeralding",
                GuildName = "",
                RequestMessage = "!inv 1234",
                RequestSource = RequestSource.WHISPER,
                RequestDate = new DateTime(2020, 6, 6, 9, 53, 54)
            };

            PartyRequest request = new LogFileParser().ParseLine(line);

            request.Should().BeEquivalentTo(expected);
        }
    }
}
