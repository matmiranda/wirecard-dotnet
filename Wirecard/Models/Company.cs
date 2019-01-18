using Newtonsoft.Json;

namespace Wirecard.Models
{
    public class Company
    {
        [JsonProperty("name", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Name { get; set; }
        [JsonProperty("businessName", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string BusinessName { get; set; }
        [JsonProperty("openingDate", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string OpeningDate { get; set; }
        [JsonProperty("taxDocument", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Taxdocument TaxDocument { get; set; }
        [JsonProperty("mainActivity", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Mainactivity MainActivity { get; set; }
        [JsonProperty("phone", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Phone Phone { get; set; }
        [JsonProperty("address", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Address Address { get; set; }
        [JsonProperty("monthlyRevenue", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string MonthlyRevenue { get; set; }
        [JsonProperty("constitutionType", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string ConstitutionType { get; set; }
    }
}