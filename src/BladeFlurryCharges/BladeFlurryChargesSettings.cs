﻿using PoeHUD.Hud.Settings;
using PoeHUD.Plugins;

namespace BladeFlurryCharges
{
    public class BladeFlurryChargesSettings : SettingsBase
    {
        public BladeFlurryChargesSettings()
        {
            LeftClick = false;
            TimeCheckCharges = new RangeNode<int>(30,10,1000);
        }
        
        [Menu("Use Left Click", 1)]
        public ToggleNode LeftClick { get; set; }
        [Menu("Every N ms check charges")]
        public RangeNode<int> TimeCheckCharges { get; set; }
    }
}
