using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace LearnosityDotNetHelper
{
    public class Time
    {
        [JsonProperty("max_time")]
        public int? MaxTime { get; set; }

        [JsonProperty("countdown")]
        public int? Countdown { get; set; }

        [JsonProperty("limit_type")]
        public string? LimitType { get; set; }
    }

}
