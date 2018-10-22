using Newtonsoft.Json;

namespace WirecardCSharp.Models
{
    public class Transferinstrument
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string method { get; set; }
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Bankaccount bankAccount { get; set; }
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Moipaccount moipAccount { get; set; }
    }
}