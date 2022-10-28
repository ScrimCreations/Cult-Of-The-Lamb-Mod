using MelonLoader;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace COTLMod.Utils
{
    internal class LocalPlayer
    {
        public static GameObject LPPlayer = GameObject.Find("Game Prefab/Units/PlayerPrefab(Clone)");

        public static void SpeedHack()
        {
            try
            {
                LPPlayer.GetComponent<PlayerController>().DefaultRunSpeed = 26f;
                LPPlayer.GetComponent<PlayerController>().RunSpeed = 26f;
                LPPlayer.GetComponent<PlayerController>().DodgeSpeed = 26f;
            }
            catch
            {
                MelonLogger.Msg("Couldn't get speed component(s)");
            }
        }

        public static void NoCoolDowns()
        {
            try
            {

            }
            catch
            {

            }
        }

    }
}
