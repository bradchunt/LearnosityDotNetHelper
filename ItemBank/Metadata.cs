using Newtonsoft.Json;

namespace LearnosityDotNetHelper;

public class Metadata
{
    [JsonProperty("distractor_rationale")]
    public string? DistractorRationale { get; set; }

    [JsonProperty("scoring_type")]
    public string? ScoringType { get; set; }
}
