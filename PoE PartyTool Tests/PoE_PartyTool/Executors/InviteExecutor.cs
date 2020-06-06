using System.Windows.Forms;

namespace PoE_PartyTool_Tests.PoE_PartyTool.Executors
{
    public class InviteExecutor
    {
        public void Execute(string playername)
        {
            Clipboard.SetText("/invite " + playername);
            SendKeys.SendWait("{ENTER}");
            SendKeys.SendWait("^{v}");
            SendKeys.SendWait("{ENTER}");
        }
    }
}
