using Newtonsoft.Json;

namespace WirecardCSharp.Models
{
    public class Keys
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Basicauth basicAuth { get; set; }
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string encryption { get; set; }
    }
}
