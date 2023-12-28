using Newtonsoft.Json;

namespace LearnosityDotNetHelper;

public class Validation
{   
    [JsonProperty("scoring_type")]
    public string? ScoringType { get; set; }
    [JsonProperty("valid_response")]
    public ValidResponse? ValidResponse { get; set; } = new ValidResponse();    
}
