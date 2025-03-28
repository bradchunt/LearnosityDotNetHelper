using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace LearnosityDotNetHelper
{
    public class Activity
    {
      
        [JsonProperty("reference")]
        public string? Reference { get; set; } = string.Empty;

        [JsonProperty("title")]
        public string? Title { get; set; } = string.Empty;

        [JsonProperty("description")]
        public string? Description { get; set; } = string.Empty;

        [JsonProperty("tags")]
        public List<Tag> Tags { get; set; } = new List<Tag>();

        [JsonProperty("status")]
        public Statuses? Status { get; set; }

        [JsonProperty("data")]
        public ActivityData ActivityData { get; set; } = new ActivityData();


    }
}
