using Newtonsoft.Json;

namespace Wirecard.Models
{
    public class PlanRequest
    {
        [JsonProperty("code", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Code { get; set; }
        [JsonProperty("name", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Name { get; set; }
        [JsonProperty("description", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Description { get; set; }
        [JsonProperty("amount", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int Amount { get; set; }
        [JsonProperty("setup_fee", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int Setup_Fee { get; set; }
        [JsonProperty("max_qty", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int Max_Qty { get; set; }
        [JsonProperty("interval", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Interval Interval { get; set; }
        [JsonProperty("billing_cycles", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int Billing_Cycles { get; set; }
        [JsonProperty("trial", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Trial Trial { get; set; }
        [JsonProperty("payment_method", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Payment_Method { get; set; }
        [JsonProperty("status", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Status { get; set; }
    }
}