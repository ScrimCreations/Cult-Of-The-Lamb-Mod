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
using System.Threading;
using System.IO;

[assembly: MelonInfo(typeof(MainMod), "COTLMod", "1.3", "Scrim")]
[assembly: MelonColor(ConsoleColor.DarkRed)]
[assembly: MelonPriority(0)]
[assembly: MelonGame("Massive Monster", "Cult Of The Lamb")]

namespace COTLMod
{
    public class MainMod : MelonMod
    {
        public static string ModVersion = "1.3";
        static bool menutog = false;

        public override void OnApplicationStart()
        {
            Console.Title = "Cult Of The Lamb [MODDED]";
            Console.ForegroundColor = ConsoleColor.White;
            MelonLogger.Msg("Loading Menu and Utilities...");
            MelonEvents.OnGUI.Subscribe(defaultmenustate, 1);
            Configs.Load();
            Thread.Sleep(3000);
            Configs.LoadBind();
            MelonLogger.Msg("Done!");
            MelonLogger.Msg($"[{Configs.MenuToggKeybind}] to Toggle the menu ON or OFF");
        }

        void defaultmenustate()
        {
            ModGUI.MainMenu(false);
        }

        public override void OnUpdate()
        {
            if (Input.GetKeyDown(Configs.MenuToggKeybind))
            {
                menutog = !menutog;
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
