using Newtonsoft.Json;

namespace WirecardCSharp.Models
{
    public class Next
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string href { get; set; }
    }
}