﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace COTLMod.Utils
{
    internal class ModGUI
    {
        static string SetButtonText1 = "<color=red>OFF</color>";
        static string SetButtonText2 = "<color=red>OFF</color>";
        static string SetButtonText3 = "<color=red>OFF</color>";
        static string SetButtonText4 = "<color=red>OFF</color>";
        static string SetButtonText5 = "<color=red>OFF</color>";

        public static bool speedhack = false;
        public static bool nocliphack = false;
        public static bool maxweapondmg = false;
        public static bool Infhealth = false;
        public static bool NoCools = false;

        public static void MainMenu(bool state)
        {
            if (state)
            {
                GUI.backgroundColor = new Color(200, 0, 0, 255);
                GUI.color = new Color(255, 255, 255, 255);
                GUI.Box(new Rect(0, 300, 500, 700), $"<size=30><color=red>COTLMod</color> By Scrim [v{MainMod.ModVersion}]</size>");

                if (GUI.Button(new Rect(0, 350, 500, 40), $"Speed Hack [{SetButtonText1}]"))
                {
                    speedhack = !speedhack;

                    if (speedhack)
                    {
                        SetButtonText1 = "<color=green>ON</color>";
                        LocalPlayer.SpeedHack(true);
                    }
                    else
                    {
                        SetButtonText1 = "<color=red>OFF</color>";
                        LocalPlayer.SpeedHack(false);
                    }
                }

                if (GUI.Button(new Rect(0, 400, 500, 40), $"Noclip [{SetButtonText2}]"))
                {
                    nocliphack = !nocliphack;

                    if (nocliphack)
                    {
                        SetButtonText2 = "<color=green>ON</color>";
                        LocalPlayer.NoClip(true);
                    }
                    else
                    {
                        SetButtonText2 = "<color=red>OFF</color>";
                        LocalPlayer.NoClip(false);
                    }
                }

                if (GUI.Button(new Rect(0, 450, 500, 40), $"Overpowered Weapons [{SetButtonText3}]"))
                {
                    maxweapondmg = !maxweapondmg;

                    if (maxweapondmg)
                    {
                        SetButtonText3 = "<color=green>ON</color>";
                        LocalPlayer.OPWeapons(true);
                    }
                    else
                    {
                        SetButtonText3 = "<color=red>OFF</color>";
                        LocalPlayer.OPWeapons(false);
                    }
                }

                if (GUI.Button(new Rect(0, 500, 500, 40), $"Inf Health [{SetButtonText4}]"))
                {
                    Infhealth = !Infhealth;

                    if (Infhealth)
                    {
                        SetButtonText4 = "<color=green>ON</color>";
                        LocalPlayer.InfHealth(true);
                    }
                    else
                    {
                        SetButtonText4 = "<color=red>OFF</color>";
                        LocalPlayer.InfHealth(false);
                    }
                }

                if (GUI.Button(new Rect(0, 550, 500, 40), $"No Cooldowns [{SetButtonText5}]"))
                {
                    NoCools = !NoCools;

                    if (NoCools)
                    {
                        SetButtonText5 = "<color=green>ON</color>";
                        LocalPlayer.NoCoolDowns(true);
                    }
                    else
                    {
                        SetButtonText5 = "<color=red>OFF</color>";
                        LocalPlayer.NoCoolDowns(false);
                    }
                }

                if (GUI.Button(new Rect(0, 750, 500, 40), "Quit Game"))
                {
                    Process.GetCurrentProcess().Kill();
                }

                if (GUI.Button(new Rect(0, 800, 500, 40), "Restart Game"))
                {
                    Process.Start("Cult Of The Lamb.exe");
                    Process.GetCurrentProcess().Kill();
                }
            }
            else
            {
                GUI.backgroundColor = new Color(0, 0, 0, 0);
                GUI.color = new Color(0, 0, 0, 0);
                GUI.Box(new Rect(0, 0, 0, 0), "");
                GUI.Button(new Rect(0, 0, 0, 0), "");
            }
        }
    }
}
