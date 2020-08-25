using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Verse;

namespace EnhancedDevelopment.Embrasures
{
    abstract class Patch
    {
        /// <summary>
        /// Checks if this Patch should be applied now.
        /// </summary>
        /// <returns>Returns true if the Patch should be applied.</returns>
        protected abstract bool ShouldPatchApply();

        /// <summary>
        /// Apply the patch.
        /// </summary>
        protected abstract void ApplyPatch(Harmony harmony = null);

        /// <summary>
        /// The Description of this patch.
        /// Mainly used for logging.
        /// </summary>
        /// <returns>The Patch Description.</returns>
        protected abstract string PatchDescription();

        /// <summary>
        /// Checks if this Patch needs to be applied, and applies if needed.
        /// </summary>
        public void ApplyPatchIfRequired(Harmony harmony = null)
        {
            string _LogLocation = "EnhancedDevelopment.Embrasures.ApplyPatchIfRequired: ";

            if (this.ShouldPatchApply())
            {
                Log.Message(_LogLocation + "Applying Patch: " + this.PatchDescription());
                this.ApplyPatch(harmony);
                Log.Message(_LogLocation + "Applied Patch: " + this.PatchDescription());
            }
            else
            {
                Log.Message(_LogLocation + "Skipping Applying Patch: " + this.PatchDescription());
            }
        }

    } //PAtch
}
