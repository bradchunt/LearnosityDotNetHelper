using Newtonsoft.Json;

namespace LearnosityDotNetHelper
{
	public class Region
	{
        [JsonProperty("widgets")]
 
        public List<Widget>? Widgets { get; set; } = new List<Widget>();

        [JsonProperty("width")]
        public int Width { get; set; }
    

        [JsonProperty("type")]
        public string? Type { get; set; }
    }
}