using Newtonsoft.Json;

namespace WirecardCSharp.Models
{
    public class Holder
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string fullname { get; set; }
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string birthdate { get; set; }
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Taxdocument taxDocument { get; set; }
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Phone phone { get; set; }
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Billingaddress billingAddress { get; set; }
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool thirdParty { get; set; }
    }
}
