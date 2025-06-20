using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace LearnosityDotNetHelper
{
    public class Configuration
    {
        [JsonProperty("idle_timeout")]
        public bool? IdleTimeout { get; set; }

        [JsonProperty("fontsize")]
        public string? FontSize { get; set; }

        [JsonProperty("dynamic")]
        public bool? Dynamic { get; set; }

        [JsonProperty("events")]
        public bool? Events { get; set; }

        [JsonProperty("preload_audio_player")]
        public bool? PreloadAudioPlayer { get; set; }

        [JsonProperty("shuffle_items")]
        public bool? ShuffleItems { get; set; }
    }


}
