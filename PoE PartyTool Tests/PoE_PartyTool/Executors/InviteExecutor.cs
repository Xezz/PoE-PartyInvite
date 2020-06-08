using PoE_PartyTool_Tests.PoE_PartyTool.Model;
using System.Windows.Forms;

namespace PoE_PartyTool_Tests.PoE_PartyTool.Executors
{
    public class InviteExecutor
    {
        public void Execute(string characterName)
        {
            Clipboard.SetText("/invite " + characterName);
            SendKeys.SendWait("{ENTER}");
            SendKeys.SendWait("^{v}");
            SendKeys.SendWait("{ENTER}");
        }
    }
}
