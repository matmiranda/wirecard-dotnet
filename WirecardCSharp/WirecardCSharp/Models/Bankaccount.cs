using Newtonsoft.Json;
using System;

namespace WirecardCSharp.Models
{
    public partial class Bankaccount
    {
        [JsonIgnore, Obsolete("Utilize a propriedade que inicia com a letra maiúscula. Essa deixará de existir a partir da versão 2.0.0.")]
        public string id { get => Id; set => Id = value; }
        [JsonIgnore, Obsolete("Utilize a propriedade que inicia com a letra maiúscula. Essa deixará de existir a partir da versão 2.0.0.")]
        public int agencyNumber { get => AgencyNumber; set => AgencyNumber = value; }
        [JsonIgnore, Obsolete("Utilize a propriedade que inicia com a letra maiúscula. Essa deixará de existir a partir da versão 2.0.0.")]
        public Holder holder { get => Holder; set => Holder = value; }
        [JsonIgnore, Obsolete("Utilize a propriedade que inicia com a letra maiúscula. Essa deixará de existir a partir da versão 2.0.0.")]
        public int accountNumber { get => AccountNumber; set => AccountNumber = value; }
        [JsonIgnore, Obsolete("Utilize a propriedade que inicia com a letra maiúscula. Essa deixará de existir a partir da versão 2.0.0.")]
        public string status { get => Status; set => Status = value; }
        [JsonIgnore, Obsolete("Utilize a propriedade que inicia com a letra maiúscula. Essa deixará de existir a partir da versão 2.0.0.")]
        public DateTime createdAt { get => CreatedAt; set => CreatedAt = value; }
        [JsonIgnore, Obsolete("Utilize a propriedade que inicia com a letra maiúscula. Essa deixará de existir a partir da versão 2.0.0.")]
        public string accountCheckNumber { get => AccountCheckNumber; set => AccountCheckNumber = value; }
        [JsonIgnore, Obsolete("Utilize a propriedade que inicia com a letra maiúscula. Essa deixará de existir a partir da versão 2.0.0.")]
        public _Links _links { get => _Links; set => _Links = value; }
        [JsonIgnore, Obsolete("Utilize a propriedade que inicia com a letra maiúscula. Essa deixará de existir a partir da versão 2.0.0.")]
        public string bankName { get => BankName; set => BankName = value; }
        [JsonIgnore, Obsolete("Utilize a propriedade que inicia com a letra maiúscula. Essa deixará de existir a partir da versão 2.0.0.")]
        public string type { get => Type; set => Type = value; }
        [JsonIgnore, Obsolete("Utilize a propriedade que inicia com a letra maiúscula. Essa deixará de existir a partir da versão 2.0.0.")]
        public string agencyCheckNumber { get => AgencyCheckNumber; set => AgencyCheckNumber = value; }
        [JsonIgnore, Obsolete("Utilize a propriedade que inicia com a letra maiúscula. Essa deixará de existir a partir da versão 2.0.0.")]
        public string bankNumber { get => BankNumber; set => BankNumber = value; }
    }
    public partial class Bankaccount
    {
        [JsonProperty("id", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Id { get; set; }
        [JsonProperty("agencyNumber", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int AgencyNumber { get; set; }
        [JsonProperty("holder", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Holder Holder { get; set; }
        [JsonProperty("accountNumber", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int AccountNumber { get; set; }
        [JsonProperty("status", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Status { get; set; }
        [JsonProperty("createdAt", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public DateTime CreatedAt { get; set; }
        [JsonProperty("accountCheckNumber", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string AccountCheckNumber { get; set; }
        [JsonProperty("_links", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public _Links _Links { get; set; }
        [JsonProperty("bankName", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string BankName { get; set; }
        [JsonProperty("type", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Type { get; set; }
        [JsonProperty("agencyCheckNumber", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string AgencyCheckNumber { get; set; }
        [JsonProperty("bankNumber", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string BankNumber { get; set; }
    }
}
