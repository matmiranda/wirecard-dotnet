using Newtonsoft.Json;

namespace Wirecard.Models
{
    public class _Self
    {
        [JsonProperty("href", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Href { get; set; }
    }
}