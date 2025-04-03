using Newtonsoft.Json;


namespace LearnosityDotNetHelper
{
    public class ActivityReferences
    {
        [JsonProperty("references")]
        public List<string>? References { get; set; } = new List<string>();
    }
}
