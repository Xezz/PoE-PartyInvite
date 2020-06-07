using FluentAssertions;
using PoE_PartyTool_Tests.PoE_PartyTool.Executors;
using PoE_PartyTool_Tests.PoE_PartyTool.Model;
using PoE_PartyTool_Tests.PoE_PartyTool.Utilities;
using System;
using Xunit;

namespace Poe_PartyTool_Test.PoE_PartyTool.Utilities
{
    public class RegExPatternsTest
    {
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

            PartyRequest request = RegexPatterns.Matchregex(line);

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

            PartyRequest request = RegexPatterns.Matchregex(line);

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

            PartyRequest request = RegexPatterns.Matchregex(line);

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

            PartyRequest request = RegexPatterns.Matchregex(line);

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

            PartyRequest request = RegexPatterns.Matchregex(line);

            request.Should().BeEquivalentTo(expected);
        }
    }
}
