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
    internal class LocalPlayer
    {
        public static float SpeedHackSpeed = 15.5f;
        public static float DeafultPlyrSpeed = 4.5f;
        public static float DefaultDodgeSpeed = 11.5f;

        public static void SpeedHack(bool state)
        {
            if (state)
            {
                try
                {
                    foreach (Component PlayerComp in Resources.FindObjectsOfTypeAll<PlayerController>())
                    {
                        var plyr = PlayerComp.GetComponent<PlayerController>();
                        plyr.GetComponent<PlayerController>().speed = SpeedHackSpeed;
                        plyr.GetComponent<PlayerController>().DefaultRunSpeed = SpeedHackSpeed;
                        plyr.GetComponent<PlayerController>().DodgeSpeed = SpeedHackSpeed;
                        plyr.GetComponent<PlayerController>().RunSpeed = SpeedHackSpeed;
                    }
                }
                catch { MelonLogger.Msg("Couldn't get player component(s) for Speed Hacks"); }
            }
            else
            {
                try
                {
                    foreach (Component PlayerComp in Resources.FindObjectsOfTypeAll<PlayerController>())
                    {
                        var plyr = PlayerComp.GetComponent<PlayerController>();
                        plyr.GetComponent<PlayerController>().speed = DeafultPlyrSpeed;
                        plyr.GetComponent<PlayerController>().DefaultRunSpeed = DeafultPlyrSpeed;
                        plyr.GetComponent<PlayerController>().DodgeSpeed = DefaultDodgeSpeed;
                        plyr.GetComponent<PlayerController>().RunSpeed = DeafultPlyrSpeed;
                    }
                }
                catch { MelonLogger.Msg("Couldn't get player component(s) for Speed Hacks!"); }
            }
        }

        public static void NoClip(bool state)
        {
            if (state)
            {
                try
                {
                    foreach (Component PlayerComp in Resources.FindObjectsOfTypeAll<PlayerController>())
                    {
                        var plyr = PlayerComp.GetComponent<CircleCollider2D>();
                        plyr.GetComponent<CircleCollider2D>().isTrigger = true;
                    }
                }
                catch { MelonLogger.Msg("Couldn't get player component(s) for Noclip!"); }
            }
            else
            {
                try
                {
                    foreach (Component PlayerComp in Resources.FindObjectsOfTypeAll<PlayerController>())
                    {
                        var plyr = PlayerComp.GetComponent<CircleCollider2D>();
                        plyr.GetComponent<CircleCollider2D>().isTrigger = false;
                    }
                }
                catch { MelonLogger.Msg("Couldn't get player component(s) for Noclip!"); }
            }
        }

        public static void OPWeapons(bool state)
        {
            if (state)
            {
                try
                {
                    foreach (Component PlayerComp in Resources.FindObjectsOfTypeAll<PlayerWeapon>())
                    {
                        var plyr = PlayerComp.GetComponent<PlayerWeapon>();
                        plyr.GetComponent<PlayerWeapon>().CurrentWeapon.CriticalChance = 100f;
                        plyr.GetComponent<PlayerWeapon>().CurrentWeapon.AttackRateMultiplier = 100f;
                        plyr.GetComponent<PlayerWeapon>().CurrentWeapon.WeaponDamageMultiplier = 200f;
                        plyr.GetComponent<PlayerWeapon>().CurrentWeapon.HealChance = 100f;
                        plyr.GetComponent<PlayerWeapon>().CurrentWeapon.HealAmount = 100f;
                        plyr.GetComponent<PlayerWeapon>().CurrentWeapon.RangeMultiplier = 100f;
                        plyr.GetComponent<PlayerWeapon>().CurrentWeapon.XPDropMultiplier = 100f;
                        plyr.GetComponent<PlayerWeapon>().CurrentWeapon.PoisonChance = 100f;
                        //plyr.GetComponent<PlayerWeapon>().CurrentWeaponLevel = 50;
                    }
                }
                catch { MelonLogger.Msg("Couldn't get Weapon component(s)"); }
            }
            else
            {
                try
                {
                    foreach (Component PlayerComp in Resources.FindObjectsOfTypeAll<PlayerWeapon>())
                    {
                        var plyr = PlayerComp.GetComponent<PlayerWeapon>();
                        plyr.GetComponent<PlayerWeapon>().CurrentWeapon.CriticalChance = 1f;
                        plyr.GetComponent<PlayerWeapon>().CurrentWeapon.AttackRateMultiplier = 1f;
                        plyr.GetComponent<PlayerWeapon>().CurrentWeapon.WeaponDamageMultiplier = 1f;
                        plyr.GetComponent<PlayerWeapon>().CurrentWeapon.HealChance = 1f;
                        plyr.GetComponent<PlayerWeapon>().CurrentWeapon.HealAmount = 1f;
                        plyr.GetComponent<PlayerWeapon>().CurrentWeapon.RangeMultiplier = 1f;
                        plyr.GetComponent<PlayerWeapon>().CurrentWeapon.XPDropMultiplier = 1f;
                        plyr.GetComponent<PlayerWeapon>().CurrentWeapon.PoisonChance = 1f;
                        //plyr.GetComponent<PlayerWeapon>().CurrentWeaponLevel = 5;
                    }
                }
                catch { MelonLogger.Msg("Couldn't get Weapon component(s)"); }
            }
        }

        public static void InfHealth(bool state)
        {
            if (state)
            {
                try
                {
                    foreach (Component PlayerComp in Resources.FindObjectsOfTypeAll<HealthPlayer>())
                    {
                        var plyr = PlayerComp.GetComponent<HealthPlayer>();
                        plyr.GetComponent<HealthPlayer>().totalHP = 999f;
                        plyr.GetComponent<HealthPlayer>()._totalHP = 999f;
                        plyr.GetComponent<HealthPlayer>().HP = 999f;
                    }
                }
                catch { MelonLogger.Msg("Couldn't get player component(s) for health"); }
            }
            else
            {
                try
                {
                    foreach (Component PlayerComp in Resources.FindObjectsOfTypeAll<HealthPlayer>())
                    {
                        //Idk the defualt health so goodluck lmao
                        var plyr = PlayerComp.GetComponent<HealthPlayer>();
                        plyr.GetComponent<HealthPlayer>().totalHP = 5f;
                        plyr.GetComponent<HealthPlayer>()._totalHP = 5f;
                        plyr.GetComponent<HealthPlayer>().HP = 5f;
                    }
                }
                catch { MelonLogger.Msg("Couldn't get player component(s) for health"); }
            }
        }

        public static void NoCoolDowns(bool state)
        {
            if (state)
            {
                try
                {
                    foreach (Component PlayerComp in Resources.FindObjectsOfTypeAll<PlayerController>())
                    {
                        var plyr = PlayerComp.GetComponent<PlayerController>();
                        plyr.GetComponent<PlayerController>().DodgeDelay = 0f;
                    }
                }
                catch { MelonLogger.Msg("Couldn't get player component(s) for cooldown removal"); }
            }
            else
            {
                try
                {
                    foreach (Component PlayerComp in Resources.FindObjectsOfTypeAll<PlayerController>())
                    {
                        var plyr = PlayerComp.GetComponent<PlayerController>();
                        plyr.GetComponent<PlayerController>().DodgeDelay = 0.28f;
                    }
                }
                catch { MelonLogger.Msg("Couldn't get player component(s) for cooldown removal"); }
            }
        }

    }
}
