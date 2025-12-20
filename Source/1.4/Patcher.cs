using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Verse;
using HarmonyLib;

namespace EnhancedDevelopment.Embrasures
{
    [StaticConstructorOnStartup]
    internal class Patcher
    {
        static Patcher()
        {
            string _LogLocation = "EnhancedDevelopment.Embrasures.Patcher(): ";

            Log.Message(_LogLocation + "Starting.");

            //Create List of Patches
            List<Patch> _Patches = new List<Patch>();
            _Patches.Add(new Patch_EmbrasureDef());

            //Create Harmony Instance
            Harmony _Harmony = new Harmony("EnhancedDevelopment.Embrasures");

            //Iterate Patches
            _Patches.ForEach(p => p.ApplyPatchIfRequired(_Harmony));

            Log.Message(_LogLocation + "Complete.");
        }

        /// <summary>
        /// Debug Logging Helper
        /// </summary>
        /// <param name="objectToTest"></param>
        /// <param name="name"></param>
        /// <param name="logSucess"></param>
        public static void LogNULL(object objectToTest, String name, bool logSucess = false)
        {
            if (objectToTest == null)
            {
                Log.Error(name + " Is NULL.");
            }
            else if (logSucess)
            {
                Log.Message(name + " Is Not NULL.");
            }
        }

    }

}
