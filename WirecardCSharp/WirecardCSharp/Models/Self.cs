using Newtonsoft.Json;

namespace WirecardCSharp.Models
{
    public class Self
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string href { get; set; }
    }
}