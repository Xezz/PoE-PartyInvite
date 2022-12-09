using FluentAssertions;
using PoE_PartyTool.PoE_PartyTool.Model;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Poe_PartyTool_Test.PoE_PartyTool.Model
{
    public class RequestSourceBuilderTest
    {
        [Fact]
        public void WhisperText_FromString_MappedToWhisper()
        {
            RequestSource actual = RequestSourceBuilder.FromString("@From ");
            actual.Should().BeEquivalentTo(RequestSource.WHISPER);
        }

        [Fact]
        public void GuildText_FromString_MappedToWhisper()
        {
            RequestSource actual = RequestSourceBuilder.FromString("&");
            actual.Should().BeEquivalentTo(RequestSource.GUILD);
        }

        [Fact]
        public void GlobalText_FromString_MappedToWhisper()
        {
            RequestSource actual = RequestSourceBuilder.FromString("#");
            actual.Should().BeEquivalentTo(RequestSource.GLOBAL);
        }

        [Fact]
        public void TradeText_FromString_MappedToWhisper()
        {
            RequestSource actual = RequestSourceBuilder.FromString("$");
            actual.Should().BeEquivalentTo(RequestSource.TRADE);
        }

        [Fact]
        public void LocalText_FromString_MappedToWhisper()
        {
            RequestSource actual = RequestSourceBuilder.FromString("");
            actual.Should().BeEquivalentTo(RequestSource.LOCAL);
        }

        [Fact]
        public void nullValue_FromString_ArgumentExceptionIsThrown()
        {
            Assert.Throws<ArgumentException>(() => RequestSourceBuilder.FromString(null));
        }


        [Fact]
        public void UnexpectedValue_FromString_ArgumentExceptionIsThrown()
        {
            Assert.Throws<ArgumentException>(() => RequestSourceBuilder.FromString("§"));
        }
    }
}
