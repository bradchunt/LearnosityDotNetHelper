using Newtonsoft.Json;

namespace LearnosityDotNetHelper;

public class Definition
{
    [JsonProperty("regions")]
 
    public List<Region>? Regions {get;set;} = new List<Region>();

    [JsonProperty("widgets")]
 
    public List<Widget>? Widgets { get; set; } = new List<Widget>();

   
   [JsonProperty("vertical_divider")]
    public bool? VerticalDivider {get;set;}
}
