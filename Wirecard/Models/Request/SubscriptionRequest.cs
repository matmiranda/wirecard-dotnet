using Newtonsoft.Json;

namespace Wirecard.Models
{
    public class SubscriptionRequest
    {
        [JsonProperty("code", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Code { get; set; }
        [JsonProperty("amount", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Amount { get; set; }
        [JsonProperty("plan", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Plan Plan { get; set; }
        [JsonProperty("payment_method", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Payment_Method { get; set; }
        [JsonProperty("customer", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Customer Customer { get; set; }
        [JsonProperty("pro_rata", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Pro_Rata { get; set; }
        [JsonProperty("best_invoice_date", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Best_Invoice_Date Best_Invoice_Date { get; set; }
        [JsonProperty("next_invoice_date", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Next_Invoice_Date Next_Invoice_Date { get; set; }
        [JsonProperty("coupon", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Coupon Coupon { get; set; }
    }
}