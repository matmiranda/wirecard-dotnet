using Newtonsoft.Json;

namespace Wirecard.Models
{
    public class PaymentRequest
    {
        [JsonProperty("installmentCount", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int InstallmentCount { get; set; }
        [JsonProperty("statementDescriptor", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string StatementDescriptor { get; set; }
        [JsonProperty("delayCapture", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool DelayCapture { get; set; }
        [JsonProperty("fundingInstrument", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Fundinginstrument FundingInstrument { get; set; }
        [JsonProperty("device", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Device Device { get; set; }
        [JsonProperty("fingerprint", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Fingerprint { get; set; }
        [JsonProperty("escrow", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Escrow Escrow { get; set; }
    }
}