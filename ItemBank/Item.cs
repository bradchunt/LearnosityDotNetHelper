using Newtonsoft.Json;

namespace LearnosityDotNetHelper;

public class Item
{
    [JsonProperty("reference")]
    public string? Reference { get; set; }

    [JsonProperty("metadata")]
    public Metadata Metadata { get; set; } = new Metadata();
    
    [JsonProperty("definition")]
    public Definition? Definition { get; set; } = new Definition();
    
    [JsonProperty("status")]
    public string? Status { get; set; }

    [JsonProperty("title")]
    public string? Title { get; set; }

    /// <summary>
    /// Used only within the Learnosity Author Site.
    /// </summary>
    [JsonProperty("description")]
    public string? Description { get; set; }

     /// <summary>
    /// Should be a whole number
    /// </summary>
    [JsonProperty("difficulty")]
    public int? DifficultyLevel { get; set; }


    /// <summary>
    /// Used only within the Learnosity Author Site.
    /// </summary>
    [JsonProperty("source")]
    public string? Source { get; set; }

    /// <summary>
    /// Used only within the Learnosity Author Site.
    /// </summary>
    [JsonProperty("note")]
    public string? Note { get; set; }

    
    [JsonProperty("questions")]
    public List<QuestionReference> QuestionReferences { get; set; } = new List<QuestionReference>();
   
    [JsonProperty("tags")]
    public List<Tag> Tags { get; set; } = new List<Tag>();
 
}
