using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Harmony;
using Verse;

namespace EnhancedDevelopment.Embrasures
{
    class Patch_EmbrasureDef : Patch
    {
        protected override void ApplyPatch(HarmonyInstance harmony = null)
        {
            ThingDef _EmbrasureDef = ThingDef.Named("ED_Embrasure");

            _EmbrasureDef.fillPercent = 0.99f;
            _EmbrasureDef.costStuffCount = 2;
        }

        protected override string PatchDescription()
        {
            return "Embrasures";
        }

        protected override bool ShouldPatchApply()
        {
            return true;
        }
    }
}
