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

        public bool ChangesEnabled = false;
        public int FillPercent = 75;
        public int StuffCost = 15;

        //HP, Work, Flamability?

        //Int for Graphics Enum?

        public override void ExposeData()
        {
            base.ExposeData();

            Scribe_Values.Look<int>(ref FillPercent, "FillPercent", 75);
            Scribe_Values.Look<int>(ref StuffCost, "StuffCost", 15);
            Scribe_Values.Look<bool>(ref ChangesEnabled, "ChangesEnabled", false);
        }
        
        public void DoSettingsWindowContents(Rect canvas)
        {
            Listing_Standard _Listing_Standard = new Listing_Standard();
            _Listing_Standard.ColumnWidth = 250f;
            _Listing_Standard.Begin(canvas);
            //listing_Standard.set_ColumnWidth(rect.get_width() - 4f);


            _Listing_Standard.Label("System Enabled.");
            _Listing_Standard.Gap(12f);
            _Listing_Standard.CheckboxLabeled("Enabled", ref this.ChangesEnabled);


            _Listing_Standard.Label("Setting will only apply after a Game Restart.");
            _Listing_Standard.Gap(12f);

            _Listing_Standard.GapLine(12f);
            _Listing_Standard.Label("Fill Percent: " + FillPercent + "%");
            FillPercent = (int)(100 *_Listing_Standard.Slider((float)(FillPercent)/100f, 0.01f, 0.99f));

            _Listing_Standard.Label("Sandbags are 65%");



            _Listing_Standard.GapLine(12f);
            _Listing_Standard.Label("Stuff Cost: " + StuffCost);
            _Listing_Standard.IntAdjuster(ref StuffCost, 1, 1);
            _Listing_Standard.Label("Wall is 5 stuff");

            _Listing_Standard.End();
        }
    }

}