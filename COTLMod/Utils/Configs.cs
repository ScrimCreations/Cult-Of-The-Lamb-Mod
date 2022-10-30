using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MelonLoader;
using UnityEngine;

namespace COTLMod.Utils
{
    internal class Configs
    {
        static string BaseDir = MelonUtils.GameDirectory;
        public static string COTLModFolder = $"{BaseDir}\\Mods\\COTLMOD";
        public static KeyCode MenuToggKeybind;
        public static void Load()
        {
            if (!Directory.Exists(COTLModFolder))
            {
                MelonLogger.Msg("Making configs & saves...");

                try
                {
                    Directory.CreateDirectory(COTLModFolder);
                    File.WriteAllText($"{COTLModFolder}\\ToggleBind.cfg", Configuration.DefaultMenuToggKeybind);
                }
                catch(Exception ex) 
                {
                    Console.Beep();
                    Console.Beep();
                    MelonLogger.Msg("ERROR occured trying to make config file :(");
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("[]====== ERROR ======[]");
                    Console.WriteLine(ex.ToString());
                    Console.WriteLine("[]====== ERROR ======[]");
                    Console.ForegroundColor = ConsoleColor.White;
                    MelonLogger.Msg($"Please make your own config file: ({COTLModFolder}\\ToggleBind.cfg)");
                }
                
                MelonLogger.Msg("Done!");
            }
        }

        public static void LoadBind()
        {
            MenuToggKeybind = Enum.TryParse(Configuration.MenuToggKeybind, out MenuToggKeybind) ? MenuToggKeybind : KeyCode.LeftAlt;
        }
    }

    public class Configuration
    {
        public static string MenuToggKeybind { get; set; } = File.ReadAllText($"{Configs.COTLModFolder}\\ToggleBind.cfg");
        public static string DefaultMenuToggKeybind = "LeftAlt";
    }
}
