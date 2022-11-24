using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using MelonLoader;
using UnityEngine;

namespace COTLMod.Utils
{
    internal class LoopChecking
    {
        private static object checkobj = null;

        public static void Init()
        {
            checkobj = MelonCoroutines.Start(Check());
        }

        public static void Dispose()
        {
            MelonCoroutines.Stop(checkobj);
        }

        public static IEnumerator Check()
        {
            while(true)
            {
                _All();
                yield return new WaitForSeconds(1f);
            }
        }

        private static void _All()
        {
            //MelonLogger.Msg("IEnumerator Test");

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
            }
            else { LocalPlayer.InfHealth(false); }

            if (ModGUI.NoCools)
            {
                LocalPlayer.NoCoolDowns(true);
            }
            else { LocalPlayer.NoCoolDowns(false); }
        }
    }
}
