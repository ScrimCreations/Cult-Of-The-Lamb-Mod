using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace COTLMod.Utils
{
    internal class SecondModGUI
    {
        public static void mGUI2(bool state)
        {
            if (state)
            {
                GUI.backgroundColor = new Color(200, 0, 0, 255);
                GUI.color = new Color(255, 255, 255, 255);
                GUI.Box(new Rect(670, 300, 850, 600), $"<size=28>Extra Menu</size>");

                if (GUI.Button(new Rect(670, 360, 400, 40), "Unlock All Crown Abilities"))
                {
                    GlobalUtils.UnlockAllCrownStuff();
                }

                if (GUI.Button(new Rect(670, 460, 400, 40), "Add Hearts"))
                {
                    GlobalUtils.AddHealth();
                }

                if (GUI.Button(new Rect(670, 560, 400, 40), "Add Follower"))
                {
                    GlobalUtils.AddFollower();
                }
            }
            else
            {
                GUI.backgroundColor = new Color(0, 0, 0, 0);
                GUI.color = new Color(0, 0, 0, 0);
                GUI.Box(new Rect(0, 0, 0, 0), "");
            }
        }
    }
}
