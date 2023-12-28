

using Newtonsoft.Json;

namespace LearnosityDotNetHelper
{
      
    /// <summary>
    /// When using the API, you must submit an array of features. This object holds the array.
    /// </summary>
    public class Features
    {    
        [JsonProperty("features")]
        public List<Feature> Feature { get; set; } = new List<Feature>();
        
        [JsonProperty("meta")]
        public Meta Meta = new Meta();
    }

}

