using Newtonsoft.Json;

namespace WirecardCSharp.Models
{
    public class Phone
    {
        [JsonProperty("countryCode", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string CountryCode { get; set; }
        [JsonProperty("areaCode", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string AreaCode { get; set; }
        [JsonProperty("number", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Number { get; set; }
    }
}