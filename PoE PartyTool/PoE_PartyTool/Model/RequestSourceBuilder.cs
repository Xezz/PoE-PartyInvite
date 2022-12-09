using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoE_PartyTool.PoE_PartyTool.Model
{
    public static class RequestSourceBuilder
    {
        public static RequestSource FromString(string source)
        {
            switch (source)
            {
                case "&":
                    return RequestSource.GUILD;
                case "#":
                    return RequestSource.GLOBAL;
                case "$":
                    return RequestSource.TRADE;
                case "@From ":
                    return RequestSource.WHISPER;
                case "":
                    return RequestSource.LOCAL;
                default:
                    throw new ArgumentException("Kann source nicht matchen: ", source);
            }
        }
    }
}
