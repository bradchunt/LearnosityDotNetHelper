

using Newtonsoft.Json;

namespace LearnosityDotNetHelper;

public class Question
{
    
    //public string? Type { get; set; }=string.Empty;
    
    [JsonProperty("type")]
    //[JsonConverter(typeof(JsonStringEnumConverter))]
    public QuestionTypes Type;

    [JsonProperty("reference")]
    public string? Reference { get; set; }=string.Empty;
    
    [JsonProperty("data")]
    public Data Data { get; set; }= new Data();
}
