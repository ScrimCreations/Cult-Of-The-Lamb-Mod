using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using MelonLoader;

namespace COTLMod.Utils
{
    internal class LoopChecking
    {
        private static Timer _timer = null;

        public static void InitTimer()
        {
            MelonLogger.Msg("Loop Check Initialized!");
            MelonLogger.Msg("Timer enabled!");
            _timer = new Timer(Check, null, 0, 4500);
        }

        public static void Check(Object obj)
        {
            if (ModGUI.speedhack)
            {
                LocalPlayer.SpeedHack(true);
            }
            else { LocalPlayer.SpeedHack(false); }

            if (ModGUI.nocliphack)
            {
                LocalPlayer.NoClip(true);
            }
            else { LocalPlayer.NoClip(false); }

            if (ModGUI.maxweapondmg)
            {
                LocalPlayer.OPWeapons(true);
            }
            else { LocalPlayer.OPWeapons(false); }

            if (ModGUI.Infhealth)
            {
                LocalPlayer.InfHealth(true);
            }else { LocalPlayer.InfHealth(false); }

            if (ModGUI.NoCools)
            {
                LocalPlayer.NoCoolDowns(true);
            }else { LocalPlayer.NoCoolDowns(false); }
        }
    }
}
