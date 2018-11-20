using Newtonsoft.Json;

namespace WirecardCSharp.Models
{
    public class PaymentRequest
    {
        [JsonProperty("installmentCount", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int InstallmentCount { get; set; }
        [JsonProperty("statementDescriptor", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string StatementDescriptor { get; set; }
        [JsonProperty("fundingInstrument", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Fundinginstrument FundingInstrument { get; set; }
        [JsonProperty("device", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Device Device { get; set; }
    }
}