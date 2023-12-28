using Newtonsoft.Json;

namespace LearnosityDotNetHelper;

public class Definition
{
    [JsonProperty("widgets")]
 
    public List<Widget>? Widgets { get; set; } = new List<Widget>();
}
