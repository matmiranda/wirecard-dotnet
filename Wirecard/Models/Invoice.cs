using Newtonsoft.Json;

namespace Wirecard.Models
{
    public class Invoice
    {
        [JsonProperty("amount", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int Amount { get; set; }
        [JsonProperty("id", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int Id { get; set; }
        [JsonProperty("status", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Status Status { get; set; }
        [JsonProperty("subscription_code", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Subscription_Code { get; set; }
        [JsonProperty("creation_date", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Creation_Date Creation_Date { get; set; }
        [JsonProperty("occurrence", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int Occurrence { get; set; }
        [JsonProperty("plan", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Plan Plan { get; set; }
        [JsonProperty("customer", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Customer Customer { get; set; }
        [JsonProperty("invoiceStatus", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Invoicestatus InvoiceStatus { get; set; }
    }
}