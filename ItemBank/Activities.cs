using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace LearnosityDotNetHelper
{
    public class Activities
    {
        [JsonProperty("activities")]
        public List<Activity> Activity { get; set; } = new List<Activity>();

        [JsonProperty("meta")]
        public Meta? Meta { get; set; } 

        [JsonProperty("organisation_id ")]
        public string? OrganizationId { get; set; }
    }
}
