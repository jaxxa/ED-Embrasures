using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using Verse;

namespace EnhancedDevelopment.Embrasures.Settings
{
    class ModSettings_Embrasures : ModSettings
    {

        public float FillPercent = 0.70f;
        public int StuffCost = 15;

        //Int for Graphics Enum?

        public override void ExposeData()
        {
            base.ExposeData();

            Scribe_Values.Look<float>(ref FillPercent, "FillPercent", 0.70f);
            Scribe_Values.Look<int>(ref StuffCost, "StuffCost", 15);
        }
        
        public void DoSettingsWindowContents(Rect canvas)
        {
            Listing_Standard _Listing_Standard = new Listing_Standard();
            _Listing_Standard.ColumnWidth = 250f;
            _Listing_Standard.Begin(canvas);
            //listing_Standard.set_ColumnWidth(rect.get_width() - 4f);

            _Listing_Standard.Label("Setting will only apply after a Game Restart.");
            _Listing_Standard.Gap(12f);

            _Listing_Standard.GapLine(12f);
            _Listing_Standard.Label("Fill Percent: " + FillPercent);
            FillPercent = (float)_Listing_Standard.Slider(FillPercent, 0.1f, 1.0f);
 
            _Listing_Standard.GapLine(12f);
            _Listing_Standard.Label("Stuff Cost: " + StuffCost);
            _Listing_Standard.IntAdjuster(ref StuffCost, 1, 1);
            
            _Listing_Standard.End();
        }
    }

}