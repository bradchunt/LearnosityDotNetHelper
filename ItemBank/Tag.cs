using Newtonsoft.Json;

namespace LearnosityDotNetHelper;

public class Tag
{  
    [JsonProperty("type")]
    public string? Type {get;set;}

    [JsonProperty("name")]
    public string? Name {get;set;}
}