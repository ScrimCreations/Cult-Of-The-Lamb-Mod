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
