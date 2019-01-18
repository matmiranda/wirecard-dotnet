using Newtonsoft.Json;

namespace Wirecard.Models
{
    public class Holder
    {
        [JsonProperty("fullname", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string FullName { get; set; }
        [JsonProperty("birthdate", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string BirthDate { get; set; }
        [JsonProperty("taxDocument", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Taxdocument TaxDocument { get; set; }
        [JsonProperty("phone", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Phone Phone { get; set; }
        [JsonProperty("billingAddress", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Billingaddress BillingAddress { get; set; }
        [JsonProperty("thirdParty", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool ThirdParty { get; set; }
    }
}