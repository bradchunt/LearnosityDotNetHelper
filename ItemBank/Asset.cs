using Newtonsoft.Json;

namespace LearnosityDotNetHelper
{
	public class Asset
	{
        [JsonProperty("subkeys")]
		public string[]? Subkeys { get; set; }
		
        [JsonProperty("organisation_id")]
        public int OrganisationId { get; set; }
    }
}