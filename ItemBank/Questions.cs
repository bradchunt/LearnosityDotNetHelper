using Newtonsoft.Json;

namespace LearnosityDotNetHelper;

public class Questions
{  
    [JsonProperty("questions")]
    public List<Question> Question { get; set; } =new();
  
    [JsonProperty("meta")]
    public Meta? Meta { get; set; }

  
    [JsonProperty("organisation_id")]
    public int? OrganizationId {get;set;}
}
