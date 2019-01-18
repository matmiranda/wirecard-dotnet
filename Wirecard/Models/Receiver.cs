using Newtonsoft.Json;

namespace Wirecard.Models
{
    public class Receiver
    {
        [JsonProperty("type", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Type { get; set; }
        [JsonProperty("feePayor", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool FeePayor { get; set; }
        [JsonProperty("moipAccount", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Moipaccount MoipAccount { get; set; }
        [JsonProperty("amount", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Amount Amount { get; set; }
    }
}