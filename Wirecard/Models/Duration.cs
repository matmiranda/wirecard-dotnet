using Newtonsoft.Json;

namespace Wirecard.Models
{
    public class Duration
    {
        [JsonProperty("type", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Type { get; set; }
        [JsonProperty("occurrences", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int Occurrences { get; set; }
    }
}