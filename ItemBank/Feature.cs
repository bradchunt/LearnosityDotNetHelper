
using Newtonsoft.Json;

namespace LearnosityDotNetHelper
{
    public class Feature
    {
        [JsonProperty("reference")]
        public string? Reference { get; set; }
        
        [JsonProperty("type")]
        public string? Type { get; set; }
   
       
       [JsonProperty("data")]
        public FeatureData Data { get; set; } = new FeatureData();
    }
}