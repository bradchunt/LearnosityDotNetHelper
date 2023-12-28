using Newtonsoft.Json;

namespace LearnosityDotNetHelper
{
    public class FeatureData
    {
        [JsonProperty("type")]
        public string? Type { get; set; }
        
        [JsonProperty("player_type")]
        public string? PlayerType { get; set; }

        [JsonProperty("src")]        
        public string? Src { get; set; }
        
        [JsonProperty("heading")]
        public string? Heading { get; set; }
        
        [JsonProperty("caption")]
        public string? Caption { get; set; }

         [JsonProperty("content")]
        public string? Content { get; set; }

    }
}