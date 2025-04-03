using Newtonsoft.Json;


namespace LearnosityDotNetHelper
{
    public class ItemReferences
    {
        [JsonProperty("references")]
        public List<string>? References { get; set; } = new List<string>();
    }
}
