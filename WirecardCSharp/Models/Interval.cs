using Newtonsoft.Json;

namespace WirecardCSharp.Models
{
    public class Interval
    {
        [JsonProperty("length", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int Length { get; set; }
        [JsonProperty("unit", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Unit { get; set; }
    }
}