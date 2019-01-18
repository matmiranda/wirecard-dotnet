using Newtonsoft.Json;

namespace Wirecard.Models
{
    public class RefundRequest
    {
        [JsonProperty("amount", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Amount { get; set; }
        [JsonProperty("refundingInstrument", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Refundinginstrument RefundingInstrument { get; set; }
        [JsonProperty("creditCard", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Creditcard CreditCard { get; set; }
    }
}