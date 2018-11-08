using System;
using Newtonsoft.Json;

namespace WirecardCSharp.Models
{
    public partial class Person
    {
        [Obsolete("Utilize a propriedade que inicia com a letra maiúscula. Essa deixará de existir a partir da versão 2.0.0.")]
        public string name { get => Name; set => Name = value; }
        [Obsolete("Utilize a propriedade que inicia com a letra maiúscula. Essa deixará de existir a partir da versão 2.0.0.")]
        public string lastName { get => LastName; set => LastName = value; }
        [Obsolete("Utilize a propriedade que inicia com a letra maiúscula. Essa deixará de existir a partir da versão 2.0.0.")]
        public string birthDate { get => BirthDate; set => BirthDate = value; }
        [Obsolete("Utilize a propriedade que inicia com a letra maiúscula. Essa deixará de existir a partir da versão 2.0.0.")]
        public Taxdocument taxDocument { get => TaxDocument; set => TaxDocument = value; }
        [Obsolete("Utilize a propriedade que inicia com a letra maiúscula. Essa deixará de existir a partir da versão 2.0.0.")]
        public Identitydocument identityDocument { get => IdentityDocument; set => IdentityDocument = value; }
        [Obsolete("Utilize a propriedade que inicia com a letra maiúscula. Essa deixará de existir a partir da versão 2.0.0.")]
        public Phone phone { get => Phone; set => Phone = value; }
        [Obsolete("Utilize a propriedade que inicia com a letra maiúscula. Essa deixará de existir a partir da versão 2.0.0.")]
        public Address address { get => Address; set => Address = value; }
        [Obsolete("Utilize a propriedade que inicia com a letra maiúscula. Essa deixará de existir a partir da versão 2.0.0.")]
        public Parentsname parentsName { get => ParentsName; set => ParentsName = value; }
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
