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

[assembly: MelonInfo(typeof(MainMod), "COTLMod", "1.0", "Scrim")]
[assembly: MelonColor(ConsoleColor.DarkRed)]
[assembly: MelonPriority(0)]

namespace COTLMod
{
    public class MainMod : MelonMod
    {
        public static string ModVersion = "1.0";
        public override void OnApplicationStart()
        {
            MelonLogger.Msg("Loading Menu and Utilities...");
            MelonEvents.OnGUI.Subscribe(ModGUI.MainMenu, 100);
            MelonLogger.Msg("Done!");
        }

        public override void OnUpdate()
        {
            
        }

        public override void OnApplicationQuit()
        {
            MelonPreferences.Save();
            Process.GetCurrentProcess().Kill(); //Faster closing
        }
    }
}
