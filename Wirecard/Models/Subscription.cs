using Newtonsoft.Json;

namespace Wirecard.Models
{
    public class Subscription
    {
        [JsonProperty("amount", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int Amount { get; set; }
        [JsonProperty("code", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Code { get; set; }
        [JsonProperty("creation_date", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Creation_Date Creation_Date { get; set; }
        [JsonProperty("expiration_date", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Expiration_Date Expiration_Date { get; set; }
        [JsonProperty("trial", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Trial Trial { get; set; }
        [JsonProperty("moip_account", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Moip_Account { get; set; }
        [JsonProperty("id", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Id { get; set; }
        [JsonProperty("invoice", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Invoice Invoice { get; set; }
        [JsonProperty("plan", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Plan Plan { get; set; }
        [JsonProperty("next_invoice_date", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Next_Invoice_Date Next_Invoice_Date { get; set; }
        [JsonProperty("payment_method", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Payment_Method { get; set; }
        [JsonProperty("status", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Status { get; set; }
        [JsonProperty("customer", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Customer Customer { get; set; }
    }
}