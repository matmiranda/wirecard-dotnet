using Newtonsoft.Json;

namespace WirecardCSharp.Models
{
    public class Businesssegment
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int id { get; set; }
    }
}