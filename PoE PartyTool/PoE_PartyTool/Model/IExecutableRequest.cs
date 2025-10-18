using System;

namespace PoE_PartyTool.PoE_PartyTool.Model
{
    public interface IExecutableRequest
    {
        string CharacterName { get; }
        string GuildName { get; }
        DateTime RequestDate { get; }
        string RequestMessage { get; }
        RequestSource RequestSource { get; }
        void Execute();
    }
}