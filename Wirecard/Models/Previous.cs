using Newtonsoft.Json;

namespace Wirecard.Models
{
    public class Previous
    {
        [JsonProperty("href", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Href { get; set; }
    }
}