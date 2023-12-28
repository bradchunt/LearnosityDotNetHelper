using Newtonsoft.Json;

namespace LearnosityDotNetHelper;

public class Meta
{
    [JsonProperty("user")]
    public User User { get; set; }= new();
}
