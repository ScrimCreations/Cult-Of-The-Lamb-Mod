using System;
using System.Collections.Generic;
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

        public static void MainMenu()
        {
            GUI.backgroundColor = Color.black;
            GUI.color = new Color(200, 0, 0, 255);
            GUI.Box(new Rect(0, 0, 500, 700), $"<size=30><color=red>COTLMod</color> By Scrim [v{MainMod.ModVersion}]</size>");

            if (GUI.Button(new Rect(0, 300, 500, 50), $"Speed Hack [{SetButtonText1}]"))
            {
                speedhack = !speedhack;

                if (speedhack)
                {
                    SetButtonText1 = "<color=green>ON</color>";
                }
                else
                {
                    SetButtonText1 = "<color=red>OFF</color>";
                }
            }

            if (GUI.Button(new Rect(0, 300, 500, 50), $"Noclip [{SetButtonText2}]"))
            {
                nocliphack = !nocliphack;

                if (nocliphack)
                {
                    SetButtonText2 = "<color=green>ON</color>";
                }
                else
                {
                    SetButtonText2 = "<color=red>OFF</color>";
                }
            }

            if (GUI.Button(new Rect(0, 300, 500, 50), $"Max Weapon Damage [{SetButtonText3}]"))
            {
                maxweapondmg = !maxweapondmg;

                if (maxweapondmg)
                {
                    SetButtonText3 = "<color=green>ON</color>";
                }
                else
                {
                    SetButtonText3 = "<color=red>OFF</color>";
                }
            }

            if (GUI.Button(new Rect(0, 300, 500, 50), $"Inf Health [{SetButtonText4}]"))
            {
                Infhealth = !Infhealth;

                if (Infhealth)
                {
                    SetButtonText4 = "<color=green>ON</color>";
                }
                else
                {
                    SetButtonText4 = "<color=red>OFF</color>";
                }
            }

            if (GUI.Button(new Rect(0, 300, 500, 50), $"No Cooldowns [{SetButtonText5}]"))
            {
                NoCools = !NoCools;

                if (NoCools)
                {
                    SetButtonText5 = "<color=green>ON</color>";
                }
                else
                {
                    SetButtonText5 = "<color=red>OFF</color>";
                }
            }
        }
    }
}
