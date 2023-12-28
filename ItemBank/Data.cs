using Newtonsoft.Json;

namespace LearnosityDotNetHelper;

public class Data
{
   [JsonProperty("stimulus")]
    public string? Stimulus { get; set; }


     [JsonProperty("type")]
    //[JsonConverter(typeof(JsonStringEnumConverter))]
    public QuestionTypes Type;


    [JsonProperty("options")]
    public List<Option> Options { get; set; } = new List<Option>();
    [JsonProperty("validation")]
    public Validation Validation { get; set; } = new Validation();
    [JsonProperty("ui_style")]
    public UiStyle? UiStyle { get; set; }
    [JsonProperty("metadata")]
    public Metadata? Metadata { get; set; }
    [JsonProperty("shuffle_options")]
    public bool ShuffleOptions { get; set; }

    [JsonProperty("multiple_responses")]
    public bool MultipleResponses { get; set; }
}
