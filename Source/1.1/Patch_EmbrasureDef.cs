using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EnhancedDevelopment.Embrasures.Settings;
using HarmonyLib;
using RimWorld;
using Verse;

namespace EnhancedDevelopment.Embrasures
{
    class Patch_EmbrasureDef : Patch
    {
        protected override void ApplyPatch(Harmony harmony = null)
        {
            ThingDef _EmbrasureDef = ThingDef.Named("ED_Embrasure");
            
            _EmbrasureDef.fillPercent = (float)(Mod_Embrasures.Settings.FillPercent)/100f;

            _EmbrasureDef.costStuffCount = Mod_Embrasures.Settings.StuffCost;
        }

        protected override string PatchDescription()
        {
            return "Embrasures";
        }

        protected override bool ShouldPatchApply()
        {
            return Mod_Embrasures.Settings.ChangesEnabled;
        }
    }
}
