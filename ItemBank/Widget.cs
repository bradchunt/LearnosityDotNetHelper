using Newtonsoft.Json;

namespace LearnosityDotNetHelper;

public class Widget
{
 [JsonProperty("reference")]
 public string? Reference { get; set; }
}
