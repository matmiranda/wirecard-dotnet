using Newtonsoft.Json;

namespace WirecardCSharp.Models
{
    public class Next
    {
        [JsonProperty("href", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Href { get; set; }
    }
}