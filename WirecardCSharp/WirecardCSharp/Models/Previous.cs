using Newtonsoft.Json;

namespace WirecardCSharp.Models
{
    public class Previous
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string href { get; set; }
    }
}