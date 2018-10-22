using Newtonsoft.Json;

namespace WirecardCSharp.Models
{
    public class Phone
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string countryCode { get; set; }
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string areaCode { get; set; }
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string number { get; set; }
    }
}