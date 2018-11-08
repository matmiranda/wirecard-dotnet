using System;
using Newtonsoft.Json;

namespace WirecardCSharp.Models
{
    public partial class Holder
    {
        [Obsolete("Utilize a propriedade que inicia com a letra maiúscula. Essa deixará de existir a partir da versão 2.0.0.")]
        public string fullname { get => FullName; set => FullName = value; }
        [Obsolete("Utilize a propriedade que inicia com a letra maiúscula. Essa deixará de existir a partir da versão 2.0.0.")]
        public string birthdate { get => BirthDate; set => BirthDate = value; }
        [Obsolete("Utilize a propriedade que inicia com a letra maiúscula. Essa deixará de existir a partir da versão 2.0.0.")]
        public Taxdocument taxDocument { get => TaxDocument; set => TaxDocument = value; }
        [Obsolete("Utilize a propriedade que inicia com a letra maiúscula. Essa deixará de existir a partir da versão 2.0.0.")]
        public Phone phone { get => Phone; set => Phone = value; }
        [Obsolete("Utilize a propriedade que inicia com a letra maiúscula. Essa deixará de existir a partir da versão 2.0.0.")]
        public Billingaddress billingAddress { get => BillingAddress; set => BillingAddress = value; }
        [Obsolete("Utilize a propriedade que inicia com a letra maiúscula. Essa deixará de existir a partir da versão 2.0.0.")]
        public bool thirdParty { get => ThirdParty; set => ThirdParty = value; }
    }
    public partial class Holder
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
