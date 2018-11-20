using Newtonsoft.Json;

namespace WirecardCSharp.Models
{
    public class Previous
    {
        [JsonProperty("href", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Href { get; set; }
    }
}