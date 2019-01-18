using Newtonsoft.Json;
using System.Collections.Generic;

namespace Wirecard.Models
{
    public class CouponResponse
    {
        [JsonProperty("message", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Message { get; set; }
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
        [JsonProperty("amount", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int Amount { get; set; }
        [JsonProperty("trial", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Trial Trial { get; set; }
        [JsonProperty("alerts", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public object[] Alerts { get; set; }
        [JsonProperty("moip_account", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Moip_Account { get; set; }
        [JsonProperty("id", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Id { get; set; }
        [JsonProperty("invoice", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Invoice Invoice { get; set; }
        [JsonProperty("invoices", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public List<Invoice> Invoices { get; set; }
        [JsonProperty("plan", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Plan Plan { get; set; }
        [JsonProperty("next_invoice_date", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Next_Invoice_Date Next_Invoice_Date { get; set; }
        [JsonProperty("errors", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public object[] Errors { get; set; }
        [JsonProperty("payment_method", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Payment_Method { get; set; }
        [JsonProperty("customer", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Customer Customer { get; set; }
    }
}