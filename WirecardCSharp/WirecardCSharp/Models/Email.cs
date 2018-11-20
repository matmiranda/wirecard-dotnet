using Newtonsoft.Json;

namespace WirecardCSharp.Models
{
    public class Email
    {
        [JsonProperty("address", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Address { get; set; }
        [JsonProperty("confirmed", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool Confirmed { get; set; }
    }
}