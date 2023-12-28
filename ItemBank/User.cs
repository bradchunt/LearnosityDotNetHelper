using Newtonsoft.Json;

namespace LearnosityDotNetHelper;

public class User
{
   [JsonProperty("id")]
    public string? ID { get; set; }
    
    [JsonProperty("firstname")]
    public string? FirstName { get; set; }
    [JsonProperty("lastname")]
    public string? LastName { get; set; }
   
    [JsonProperty("email")]
    public string? Email { get; set; }
}
