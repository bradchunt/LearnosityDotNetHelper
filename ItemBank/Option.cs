using Newtonsoft.Json;

namespace LearnosityDotNetHelper;

public class Option
{
   [JsonProperty("value")]
    public string? Value { get; set; }
   [JsonProperty("label")]
    public string? Label { get; set; }
}
