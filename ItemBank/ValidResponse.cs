using Newtonsoft.Json;

namespace LearnosityDotNetHelper;

public class ValidResponse
{
    [JsonProperty("value")]
    public List<string>? Value { get; set; } = new List<string>();
     [JsonProperty("score")]
    public int? Score { get; set; }
}
