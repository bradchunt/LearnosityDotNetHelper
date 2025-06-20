using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace LearnosityDotNetHelper
{
    public class IntroItem
    {
        [JsonProperty("id")]
        public string? Id { get; set; }

        [JsonProperty("reference")]
        public string? Reference { get; set; }
    }

}
