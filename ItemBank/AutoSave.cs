using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace LearnosityDotNetHelper
{
    public class AutoSave
    {
        [JsonProperty("save_interval_duration")]
        public int? SaveIntervalDuration { get; set; }

        [JsonProperty("ui")]
        public bool? Ui { get; set; }
    }

}
