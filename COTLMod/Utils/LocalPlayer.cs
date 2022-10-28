using MelonLoader;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace COTLMod.Utils
{
    //Very Messy Code below I'm sorry!

    internal class LocalPlayer
    {
        public static GameObject LPPlayer = GameObject.Find("Game Prefab/Units/PlayerPrefab(Clone)");
        public static GameObject StarterPlyr = GameObject.Find("Game Prefab/Units/Player - Prisoner(Clone)");

        public static void SpeedHack(bool state)
        {
            if (state)
            {
                try
                {
                    try
                    {
                        StarterPlyr.GetComponent<PlayerPrisonerController>().MaxSpeed = 15f;
                        StarterPlyr.GetComponent<PlayerPrisonerController>().Speed = 15f;
                    }
                    catch
                    {
                        LPPlayer.GetComponent<PlayerController>().DefaultRunSpeed = 26f;
                        LPPlayer.GetComponent<PlayerController>().RunSpeed = 26f;
                        LPPlayer.GetComponent<PlayerController>().DodgeSpeed = 26f;
                    }
                }
                catch
                {
                    MelonLogger.Msg("Couldn't get speed component(s)");
                }
            }
            else
            {
                try
                {
                    try
                    {
                        StarterPlyr.GetComponent<PlayerPrisonerController>().MaxSpeed = 2.5f;
                        StarterPlyr.GetComponent<PlayerPrisonerController>().Speed = 2.5f;
                    }
                    catch
                    {
                        LPPlayer.GetComponent<PlayerController>().DefaultRunSpeed = 2.5f;
                        LPPlayer.GetComponent<PlayerController>().RunSpeed = 2.5f;
                        LPPlayer.GetComponent<PlayerController>().DodgeSpeed = 2.5f;
                    }
                }
                catch
                {
                    MelonLogger.Msg("Couldn't get speed component(s)");
                }
            }
        }

        public static void NoClip(bool state)
        {
            if (state)
            {

            }
            else
            {

            }
        }

        public static void OPWeapons(bool state)
        {
            if (state)
            {

            }
            else
            {

            }
        }

        public static void InfHealth(bool state)
        {
            if (state)
            {

            }
            else
            {

            }
        }

        public static void NoCoolDowns(bool state)
        {
            if (state)
            {

            }
            else
            {

            }
        }

    }
}
