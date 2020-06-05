using PoE_PartyTool.LogProcessing;
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
            string actual = fileParser.ParseLine("Line to parse");
            Assert.Equal("Line_to_parse", actual);
        }
    }
}
