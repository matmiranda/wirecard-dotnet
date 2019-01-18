using Newtonsoft.Json;

namespace Wirecard.Models
{
    public class Instructionlines
    {
        [JsonProperty("first", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string First { get; set; }
        [JsonProperty("second", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Second { get; set; }
        [JsonProperty("third", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Third { get; set; }
    }
}