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
            var expected = new PartyRequest(
                executor: new InviteExecutor(),
                requestDate: new DateTime(2020, 6, 6, 9, 53, 54),
                requestSource: RequestSource.GUILD,
                guildName: "<#TDE>",
                characterName: "GSF_HeadHeralding",
                requestMessage: "!inv"
            );

            PartyRequest request = new LogFileParser().ParseLine(line);

            request.Should().BeEquivalentTo(expected);
        }

        [Fact]
        public void TradeChatPartyRequest_map_properPartyRequest()
        {
            string line = "2020/06/06 09:53:54 399269953 acf [INFO Client 12872] $<#TDE> GSF_HeadHeralding: !inv";
			var expected = new PartyRequest(
				executor: new InviteExecutor(),
				requestDate: new DateTime(2020, 6, 6, 9, 53, 54),
				requestSource: RequestSource.TRADE,
				guildName: "<#TDE>",
				characterName: "GSF_HeadHeralding",
				requestMessage: "!inv"
			);

			PartyRequest request = new LogFileParser().ParseLine(line);

            request.Should().BeEquivalentTo(expected);
        }

        [Fact]
        public void GlobalChatPartyRequest_map_properPartyRequest()
        {
            string line = "2020/06/29 09:53:54 399269953 acf [INFO Client 12872] #<#TDE> GSF_HeadHeralding: !inv";
			var expected = new PartyRequest(
				executor: new InviteExecutor(),
				requestDate: new DateTime(2020, 6, 6, 9, 53, 54),
				requestSource: RequestSource.GLOBAL,
				guildName: "<#TDE>",
				characterName: "GSF_HeadHeralding",
				requestMessage: "!inv"
			);

			PartyRequest request = new LogFileParser().ParseLine(line);

            request.Should().BeEquivalentTo(expected);
        }

        [Fact]
        public void WhisperPartyRequest_map_properPartyRequest()
        {
            string line = "2020/06/06 09:53:54 399269953 acf [INFO Client 12872] @From <#TDE> GSF_HeadHeralding: !inv";
			var expected = new PartyRequest(
				executor: new InviteExecutor(),
				requestDate: new DateTime(2020, 6, 6, 9, 53, 54),
				requestSource: RequestSource.WHISPER,
				guildName: "<#TDE>",
				characterName: "GSF_HeadHeralding",
				requestMessage: "!inv"
			);

			PartyRequest request = new LogFileParser().ParseLine(line);

            request.Should().BeEquivalentTo(expected);
        }

        [Fact]
        public void WhisperPartyRequestOhneGilde_map_properPartyRequest()
        {
            string line = "2020/06/06 09:53:54 399269953 acf [INFO Client 12872] @From GSF_HeadHeralding: !inv 1234";
			var expected = new PartyRequest(
				executor: new InviteExecutor(),
				requestDate: new DateTime(2020, 6, 6, 9, 53, 54),
				requestSource: RequestSource.WHISPER,
				guildName: "<#TDE>",
				characterName: "GSF_HeadHeralding",
				requestMessage: "!inv 1234"
			);

			PartyRequest request = new LogFileParser().ParseLine(line);

            request.Should().BeEquivalentTo(expected);
        }
    }
}
