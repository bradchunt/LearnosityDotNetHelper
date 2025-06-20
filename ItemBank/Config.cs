using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;

namespace LearnosityDotNetHelper
{
    public class Config
    {
        [JsonProperty("configuration")]
        public Configuration? Configuration { get; set; }

        [JsonProperty("navigation")]
        public Navigation? Navigation { get; set; }

        [JsonProperty("regions")]
        public string? Regions { get; set; }

        [JsonProperty("title")]
        public string? Title { get; set; }

        [JsonProperty("subtitle")]
        public string? Subtitle { get; set; }

        [JsonProperty("administration")]
        public bool? Administration { get; set; }

        [JsonProperty("time")]
        public Time? Time { get; set; }

        [JsonProperty("region_overrides")]
        public RegionOverrides? RegionOverrides { get; set; }

    }
}
