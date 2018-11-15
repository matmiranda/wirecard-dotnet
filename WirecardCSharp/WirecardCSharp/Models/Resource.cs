using Newtonsoft.Json;

namespace WirecardCSharp.Models
{
    public class Resource
    {
        [JsonProperty("order", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Order Order { get; set; }
    }
}