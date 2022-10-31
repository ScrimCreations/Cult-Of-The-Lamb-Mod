using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace COTLMod.Utils
{
    internal class GlobalUtils
    {
        public static void UnlockAllCrownStuff()
        {
            //Will do later
            try
            {

            }
            catch { }
        }

        public static void AddHealth()
        {
            GameObject thisobject = GameObject.FindWithTag("Player");
            if(thisobject != null)
            {
                thisobject.GetComponent<HealthPlayer>().totalHP += 1f;
            }
        }

        public static void AddFollower()
        {
            //Will do later
            try
            {

            }
            catch { }
        }
    }
}
