using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace LearnosityDotNetHelper
{
    public class ActivityData
    {

        [JsonProperty("items")]
        public List<string> Items { get; set; } = new List<string>();

        [JsonProperty("config")]
        public Config? Config { get; set; }


    }
}
