using Newtonsoft.Json;

namespace Wirecard.Models
{
    public class CouponRequest
    {
        [JsonProperty("code", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Code { get; set; }
        [JsonProperty("name", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Name { get; set; }
        [JsonProperty("description", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Description { get; set; }
        [JsonProperty("discount", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Discount Discount { get; set; }
        [JsonProperty("status", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Status { get; set; }
        [JsonProperty("duration", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Duration Duration { get; set; }
        [JsonProperty("max_redemptions", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int Max_Redemptions { get; set; }
        [JsonProperty("expiration_date", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Expiration_Date Expiration_Date { get; set; }
        [JsonProperty("creation_date", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Creation_Date Creation_Date { get; set; }
        [JsonProperty("in_use", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool In_Use { get; set; }
        [JsonProperty("coupon", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Coupon Coupon { get; set; }
        [JsonProperty("plan", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Plan Plan { get; set; }
        [JsonProperty("customer", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Customer Customer { get; set; }
        [JsonProperty("billing_info", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Billing_Info Billing_Info { get; set; }
    }
}