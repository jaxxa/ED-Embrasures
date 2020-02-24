using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using Verse;

namespace EnhancedDevelopment.Embrasures.Settings
{
    class Mod_Embrasures : Verse.Mod
    {

        public static ModSettings_Embrasures Settings;

        public Mod_Embrasures(ModContentPack content) : base(content)
        {
            Mod_Embrasures.Settings = GetSettings<ModSettings_Embrasures>();
        }

        public override string SettingsCategory()
        {
            return "ED-Embrasures";
            //return base.SettingsCategory();
        }


        public override void DoSettingsWindowContents(Rect inRect)
        {
            Settings.DoSettingsWindowContents(inRect);
            //base.DoSettingsWindowContents(inRect);
        }
    }
}
