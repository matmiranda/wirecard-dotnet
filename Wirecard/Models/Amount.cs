using Newtonsoft.Json;

namespace Wirecard.Models
{
    public class Amount
    {
        [JsonProperty("currency", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Currency { get; set; }
        [JsonProperty("subtotals", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Subtotals Subtotals { get; set; }
        [JsonProperty("fixed", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int Fixed { get; set; }
        [JsonProperty("percentual", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public float Percentual { get; set; }
        [JsonProperty("paid", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int Paid { get; set; }
        [JsonProperty("total", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int Total { get; set; }
        [JsonProperty("fees", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int Fees { get; set; }
        [JsonProperty("refunds", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int Refunds { get; set; }
        [JsonProperty("liquid", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int Liquid { get; set; }
        [JsonProperty("otherReceivers", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int OtherReceivers { get; set; }
        [JsonProperty("addition", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int Addition { get; set; }
        [JsonProperty("deduction", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int Deduction { get; set; }
        [JsonProperty("gross", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int Gross { get; set; }
    }
}