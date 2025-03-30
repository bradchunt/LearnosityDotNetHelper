using Newtonsoft.Json;

namespace LearnosityDotNetHelper;

public class Items
{

    [JsonProperty("items")]
     public List<Item> Item { get; set; } = new List<Item>();

    [JsonProperty("meta")]
    public Meta? Meta { get; set; }

    [JsonProperty("organisation_id")]
    public int? OrganizationId {get;set;}

}
