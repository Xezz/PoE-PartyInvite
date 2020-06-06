using PoE_PartyTool.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace PoE_PartyTool_Tests.PoE_PartyTool.Command
{
    public class InviteCommand
    {
        [DllImport("user32.dll")]
        private static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

        [DllImport("user32.dll")]
        private static extern bool SetForegroundWindow(IntPtr hWnd);

        private readonly PoEProcessWatcher PoEProcessWatcher;

        public InviteCommand(PoEProcessWatcher processWatcher)
        {
            this.PoEProcessWatcher = processWatcher;
        }

        public void invitePlayer(String playerName)
        {

        }
    }
}
