using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace LearnosityDotNetHelper
{
    public class RegionOverrides
    {
        [JsonProperty("top-right.pause_button")]
        public bool? TopRightPauseButton { get; set; }

        [JsonProperty("top-right.timer_element")]
        public bool? TopRightTimerElement { get; set; }

        [JsonProperty("right.save_button")]
        public bool? RightSaveButton { get; set; }

        [JsonProperty("right.accessibility_button")]
        public bool? RightAccessibilityButton { get; set; }

        [JsonProperty("right.calculator_button")]
        public bool? RightCalculatorButton { get; set; }

        [JsonProperty("bottom.horizontaltoc_element")]
        public HorizontalTocElement? BottomHorizontalTocElement { get; set; }
    }

}
