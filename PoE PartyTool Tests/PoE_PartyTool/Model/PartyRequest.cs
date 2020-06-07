﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoE_PartyTool_Tests.PoE_PartyTool.Model
{
    public class PartyRequest
    {
        public DateTime RequestDate { get; set; }
        public RequestSource RequestSource { get; set; }
        public string GuildName { get; set; }
        public string CharacterName { get; set; }
        public string RequestMessage { get; set; }
    }
}
