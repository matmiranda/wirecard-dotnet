using Newtonsoft.Json;

namespace WirecardCSharp.Models
{
    public class Fundinginstrument
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Creditcard creditCard { get; set; }
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string method { get; set; }
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string brand { get; set; }
    }
}