using Newtonsoft.Json;

namespace WirecardCSharp.Models
{
    public class Self
    {
        [JsonProperty("href", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Href { get; set; }
    }
}