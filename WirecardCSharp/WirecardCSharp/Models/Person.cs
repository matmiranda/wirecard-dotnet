using System;
using Newtonsoft.Json;

namespace WirecardCSharp.Models
{
    public partial class Person
    {
        [Obsolete("Utilize a propriedade que inicia com a letra maiúscula. Essa deixará de existir a partir da versão 2.0.0.")]
        public string name { get => Name; set => value = Name; }
        [Obsolete("Utilize a propriedade que inicia com a letra maiúscula. Essa deixará de existir a partir da versão 2.0.0.")]
        public string lastName { get => LastName; set => value = LastName; }
        [Obsolete("Utilize a propriedade que inicia com a letra maiúscula. Essa deixará de existir a partir da versão 2.0.0.")]
        public string birthDate { get => BirthDate; set => value = BirthDate; }
        [Obsolete("Utilize a propriedade que inicia com a letra maiúscula. Essa deixará de existir a partir da versão 2.0.0.")]
        public Taxdocument taxDocument { get => TaxDocument; set => value = TaxDocument; }
        [Obsolete("Utilize a propriedade que inicia com a letra maiúscula. Essa deixará de existir a partir da versão 2.0.0.")]
        public Identitydocument identityDocument { get => IdentityDocument; set => value = IdentityDocument; }
        [Obsolete("Utilize a propriedade que inicia com a letra maiúscula. Essa deixará de existir a partir da versão 2.0.0.")]
        public Phone phone { get => Phone; set => value = Phone; }
        [Obsolete("Utilize a propriedade que inicia com a letra maiúscula. Essa deixará de existir a partir da versão 2.0.0.")]
        public Address address { get => Address; set => value = Address; }
        [Obsolete("Utilize a propriedade que inicia com a letra maiúscula. Essa deixará de existir a partir da versão 2.0.0.")]
        public Parentsname parentsName { get => ParentsName; set => value = ParentsName; }
    }
    public partial class Person
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
