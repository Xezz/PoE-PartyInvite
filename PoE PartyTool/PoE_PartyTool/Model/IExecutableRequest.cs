using System;

namespace PoE_PartyTool.PoE_PartyTool.Model
{
    public interface IExecutableRequest
    {
        string CharacterName { get; set; }
        string GuildName { get; set; }
        DateTime RequestDate { get; set; }
        string RequestMessage { get; set; }
        RequestSource RequestSource { get; set; }
        void Execute();
    }
}