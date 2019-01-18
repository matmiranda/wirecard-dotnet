using Newtonsoft.Json;

namespace Wirecard.Models
{
    public class Person
    {
        [JsonProperty("name", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Name { get; set; }
        [JsonProperty("lastName", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string LastName { get; set; }
        [JsonProperty("birthDate", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string BirthDate { get; set; }
        [JsonProperty("taxDocument", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Taxdocument TaxDocument { get; set; }
        [JsonProperty("identityDocument", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Identitydocument IdentityDocument { get; set; }
        [JsonProperty("phone", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Phone Phone { get; set; }
        [JsonProperty("address", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Address Address { get; set; }
        [JsonProperty("parentsName", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Parentsname ParentsName { get; set; }
    }
}