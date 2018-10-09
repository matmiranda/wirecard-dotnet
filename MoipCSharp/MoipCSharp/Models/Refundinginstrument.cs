using Newtonsoft.Json;

namespace MoipCSharp.Models
{
    public class Refundinginstrument
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Creditcard creditCard { get; set; }
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string method { get; set; }
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Moipaccount moipAccount { get; set; }
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Bankaccount bankAccount { get; set; }
    }
}