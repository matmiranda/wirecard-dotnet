using System;
using Newtonsoft.Json;

namespace WirecardCSharp.Models
{
    public partial class Company
    {
        [Obsolete("Utilize a propriedade que inicia com a letra maiúscula. Essa deixará de existir a partir da versão 2.0.0.")]
        public string name { get => Name; set => value = Name; }
        [Obsolete("Utilize a propriedade que inicia com a letra maiúscula. Essa deixará de existir a partir da versão 2.0.0.")]
        public string businessName { get => BusinessName; set => value = BusinessName; }
        [Obsolete("Utilize a propriedade que inicia com a letra maiúscula. Essa deixará de existir a partir da versão 2.0.0.")]
        public string openingDate { get => OpeningDate; set => value = OpeningDate; }
        [Obsolete("Utilize a propriedade que inicia com a letra maiúscula. Essa deixará de existir a partir da versão 2.0.0.")]
        public Taxdocument taxDocument { get => TaxDocument; set => value = TaxDocument; }
        [Obsolete("Utilize a propriedade que inicia com a letra maiúscula. Essa deixará de existir a partir da versão 2.0.0.")]
        public Mainactivity mainActivity { get => MainActivity; set => value = MainActivity; }
        [Obsolete("Utilize a propriedade que inicia com a letra maiúscula. Essa deixará de existir a partir da versão 2.0.0.")]
        public Phone phone { get => Phone; set => value = Phone; }
        [Obsolete("Utilize a propriedade que inicia com a letra maiúscula. Essa deixará de existir a partir da versão 2.0.0.")]
        public Address address { get => Address; set => value = Address; }
        [Obsolete("Utilize a propriedade que inicia com a letra maiúscula. Essa deixará de existir a partir da versão 2.0.0.")]
        public string monthlyRevenue { get => MonthlyRevenue; set => value = MonthlyRevenue; }
        [Obsolete("Utilize a propriedade que inicia com a letra maiúscula. Essa deixará de existir a partir da versão 2.0.0.")]
        public string constitutionType { get => ConstitutionType; set => value = ConstitutionType; }
    }
    public partial class Company
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
