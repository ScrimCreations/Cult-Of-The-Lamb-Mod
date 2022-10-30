using MelonLoader;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using Lamb;
using RewiredConsts;

namespace COTLMod.Utils
{
    //Very Messy Code below lmao
    internal class LocalPlayer
    {
        public static GameObject LPPlayer = GameObject.Find("Game Prefab/Units/PlayerPrefab(Clone)");
        public static GameObject StarterPlyr = GameObject.Find("Game Prefab/Units/Player - Prisoner(Clone)");
        public static GameObject deathplayer = GameObject.Find("Death Scene/Death/Units/Player - Prisoner(Clone)");
        public static GameObject RoomPlayer = GameObject.Find("Room/CustomTransform/PlayerPrefab(Clone)");
        public static float SpeedHackSpeed = 15.5f;
        public static float DeafultPlyrSpeed = 4.5f;
        public static float DefaultDodgeSpeed = 11.5f;

        public static void SpeedHack(bool state)
        {
            if (state)
            {
                try
                {
                    try
                    {
                        deathplayer.GetComponent<PlayerController>().DefaultRunSpeed = SpeedHackSpeed;
                        deathplayer.GetComponent<PlayerController>().DodgeSpeed = SpeedHackSpeed;
                        deathplayer.GetComponent<PlayerController>().RunSpeed = SpeedHackSpeed;
                        deathplayer.GetComponent<PlayerController>().speed = SpeedHackSpeed;
                    }
                    catch { }

                    try
                    {
                        RoomPlayer.GetComponent<PlayerController>().DefaultRunSpeed = SpeedHackSpeed;
                        RoomPlayer.GetComponent<PlayerController>().DodgeSpeed = SpeedHackSpeed;
                        RoomPlayer.GetComponent<PlayerController>().RunSpeed = SpeedHackSpeed;
                        RoomPlayer.GetComponent<PlayerController>().speed = SpeedHackSpeed;
                    }
                    catch { }

                    try
                    {
                        StarterPlyr.GetComponent<PlayerPrisonerController>().MaxSpeed = SpeedHackSpeed;
                        StarterPlyr.GetComponent<PlayerPrisonerController>().Speed = SpeedHackSpeed;
                    }
                    catch { }

                    try
                    {
                        LPPlayer.GetComponent<PlayerController>().DefaultRunSpeed = SpeedHackSpeed;
                        LPPlayer.GetComponent<PlayerController>().RunSpeed = SpeedHackSpeed;
                        LPPlayer.GetComponent<PlayerController>().DodgeSpeed = SpeedHackSpeed;
                        LPPlayer.GetComponent<PlayerController>().speed = SpeedHackSpeed;
                    }
                    catch { }
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
                        deathplayer.GetComponent<PlayerController>().DefaultRunSpeed = DeafultPlyrSpeed;
                        deathplayer.GetComponent<PlayerController>().DodgeSpeed = DefaultDodgeSpeed;
                        deathplayer.GetComponent<PlayerController>().RunSpeed = DeafultPlyrSpeed;
                        deathplayer.GetComponent<PlayerController>().speed = DeafultPlyrSpeed;
                    }
                    catch { }

                    try
                    {
                        RoomPlayer.GetComponent<PlayerController>().DefaultRunSpeed = DeafultPlyrSpeed;
                        RoomPlayer.GetComponent<PlayerController>().DodgeSpeed = DefaultDodgeSpeed;
                        RoomPlayer.GetComponent<PlayerController>().RunSpeed = DeafultPlyrSpeed;
                        RoomPlayer.GetComponent<PlayerController>().speed = DeafultPlyrSpeed;
                    }
                    catch { }

                    try
                    {
                        StarterPlyr.GetComponent<PlayerPrisonerController>().MaxSpeed = DeafultPlyrSpeed;
                        StarterPlyr.GetComponent<PlayerPrisonerController>().Speed = DeafultPlyrSpeed;
                    }
                    catch { }

                    try
                    {
                        LPPlayer.GetComponent<PlayerController>().DefaultRunSpeed = DeafultPlyrSpeed;
                        LPPlayer.GetComponent<PlayerController>().RunSpeed = DeafultPlyrSpeed;
                        LPPlayer.GetComponent<PlayerController>().DodgeSpeed = DefaultDodgeSpeed;
                        LPPlayer.GetComponent<PlayerController>().speed = DeafultPlyrSpeed;
                    }
                    catch { }
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
                try
                {
                    LPPlayer.GetComponent<CircleCollider2D>().isTrigger = true;
                }
                catch { }
                try
                {
                    StarterPlyr.GetComponent<CircleCollider2D>().isTrigger = true;
                }
                catch { }
                try
                {
                    deathplayer.GetComponent<CircleCollider2D>().isTrigger = true;
                }
                catch { }
                try
                {
                    RoomPlayer.GetComponent<CircleCollider2D>().isTrigger = true;
                }
                catch { }
            }
            else
            {
                try
                {
                    LPPlayer.GetComponent<CircleCollider2D>().isTrigger = false;
                }
                catch { }
                try
                {
                    StarterPlyr.GetComponent<CircleCollider2D>().isTrigger = false;
                }
                catch { }
                try
                {
                    deathplayer.GetComponent<CircleCollider2D>().isTrigger = false;
                }
                catch { }
                try
                {
                    RoomPlayer.GetComponent<CircleCollider2D>().isTrigger = false;
                }
                catch { }
            }
        }

        public static void OPWeapons(bool state)
        {
            //Will work on later lol
            /*
            if (state)
            {
                
            }
            else
            {

            }
            */
        }

        public static void InfHealth(bool state)
        {
            if (state)
            {
                try
                {

                }
                catch { }
                try
                {

                }
                catch { }
                try
                {

                }
                catch { }
                try
                {

                }
                catch { }
            }
            else
            {
                try
                {

                }
                catch { }
                try
                {

                }
                catch { }
                try
                {

                }
                catch { }
                try
                {

                }
                catch { }
            }
        }

        public static void NoCoolDowns(bool state)
        {
            if (state)
            {
                try
                {
                    RoomPlayer.GetComponent<PlayerController>().DodgeDelay = 0f;
                }
                catch { }
                try
                {
                    LPPlayer.GetComponent<PlayerController>().DodgeDelay = 0f;
                }
                catch { }
                try
                {

                }
                catch { }
            }
            else
            {
                try
                {
                    RoomPlayer.GetComponent<PlayerController>().DodgeDelay = 0.28f;
                }
                catch { }
                try
                {
                    LPPlayer.GetComponent<PlayerController>().DodgeDelay = 0.28f;
                }
                catch { }
                try
                {

                }
                catch { }
            }
        }

    }
}
