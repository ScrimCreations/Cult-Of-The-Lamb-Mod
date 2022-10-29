using MelonLoader;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using COTLMod;
using UnityEngine;
using COTLMod.Utils;
using System.Diagnostics;

[assembly: MelonInfo(typeof(MainMod), "COTLMod", "1.1", "Scrim")]
[assembly: MelonColor(ConsoleColor.DarkRed)]
[assembly: MelonPriority(0)]

namespace COTLMod
{
    public class MainMod : MelonMod
    {
        public static string ModVersion = "1.1";
        static bool menutog = false;
        public override void OnApplicationStart()
        {
            MelonLogger.Msg("Loading Menu and Utilities...");
            MelonEvents.OnGUI.Subscribe(defaultmenustate, 1);
            MelonLogger.Msg("Done!");
            MelonLogger.Msg("Left Alt to Toggle the menu on or off");
        }

        void defaultmenustate()
        {
            ModGUI.MainMenu(false);
        }

        public override void OnUpdate()
        {
            if (Input.GetKeyDown(KeyCode.LeftAlt))
            {
                menutog = !menutog;
            }

            if (ModGUI.LoopCheckFunc)
            {

            }
            else
            {

            }
        }

        public override void OnGUI()
        {
            if (menutog) { ModGUI.MainMenu(true); } else { ModGUI.MainMenu(false); }
        }

        public override void OnApplicationQuit()
        {
            MelonPreferences.Save();
            Process.GetCurrentProcess().Kill(); //Faster closing
        }
    }
}
