using System.Text.Json;
using Newtonsoft.Json;

namespace LearnosityDotNetHelper;

public class UiStyle
{
 [JsonProperty("type")]
   public string? Type { get; set; }
}
