using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace LearnosityDotNetHelper
{
    public class Navigation
    {
        [JsonProperty("auto_save")]
        public AutoSave? AutoSave { get; set; }

        [JsonProperty("show_intro")]
        public bool? ShowIntro { get; set; }

        [JsonProperty("show_outro")]
        public bool? ShowOutro { get; set; }

        [JsonProperty("transition_speed")]
        public int? TransitionSpeed { get; set; }

        [JsonProperty("transition")]
        public string? Transition { get; set; }

        [JsonProperty("intro_item")]
        public IntroItem? IntroItem { get; set; }

        [JsonProperty("show_submit")]
        public bool? ShowSubmit { get; set; }

        [JsonProperty("skip_submit_confirmation")]
        public bool? SkipSubmitConfirmation { get; set; }

        [JsonProperty("warning_on_change")]
        public bool? WarningOnChange { get; set; }

        [JsonProperty("scrolling_indicator")]
        public bool? ScrollingIndicator { get; set; }

        [JsonProperty("scroll_to_top")]
        public bool? ScrollToTop { get; set; }

        [JsonProperty("scroll_to_test")]
        public bool? ScrollToTest { get; set; }

        [JsonProperty("swipe")]
        public bool? Swipe { get; set; }

        [JsonProperty("show_answermasking")]
        public bool? ShowAnswerMasking { get; set; }

        [JsonProperty("exit_securebrowser")]
        public bool? ExitSecureBrowser { get; set; }
    }

}
