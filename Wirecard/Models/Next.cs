using Newtonsoft.Json;

namespace Wirecard.Models
{
    public class Next
    {
        [JsonProperty("href", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Href { get; set; }
    }
}