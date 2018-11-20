using Newtonsoft.Json;

namespace WirecardCSharp.Models
{
    public class Parentsname
    {
        [JsonProperty("mother", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Mother { get; set; }
        [JsonProperty("father", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Father { get; set; }
    }
}