using PoE_PartyTool.PoE_PartyTool.Executors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoE_PartyTool.PoE_PartyTool.Model
{
    public class PartyRequest : IExecutableRequest
    {
        private readonly InviteExecutor executor;

        public PartyRequest(InviteExecutor executor, DateTime requestDate, RequestSource requestSource, string guildName, string characterName, string requestMessage)
        {
            this.executor = executor;
            RequestDate = requestDate;
            RequestSource = requestSource;
            GuildName = guildName;
            CharacterName = characterName;
            RequestMessage = requestMessage;
            
        } // PartyRequest

        
        public DateTime RequestDate { get; }
        public RequestSource RequestSource { get; }
        public string GuildName { get; }
        public string CharacterName { get; }
        public string RequestMessage { get; }


        public void Execute()
        {
            executor.Execute(CharacterName);
        }
    }
}
