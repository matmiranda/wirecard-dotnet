using System;
using Newtonsoft.Json;

namespace WirecardCSharp.Models
{
    public partial class BankAccountRequest
    {
        [JsonIgnore, Obsolete("Utilize a propriedade que inicia com a letra maiúscula. Essa deixará de existir a partir da versão 2.0.0.")]
        public string bankNumber { get => BankNumber; set => BankNumber = value; }
        [JsonIgnore, Obsolete("Utilize a propriedade que inicia com a letra maiúscula. Essa deixará de existir a partir da versão 2.0.0.")]
        public string agencyNumber { get => AgencyNumber; set => AgencyNumber = value; }
        [JsonIgnore, Obsolete("Utilize a propriedade que inicia com a letra maiúscula. Essa deixará de existir a partir da versão 2.0.0.")]
        public string agencyCheckNumber { get => AgencyCheckNumber; set => AgencyCheckNumber = value; }
        [JsonIgnore, Obsolete("Utilize a propriedade que inicia com a letra maiúscula. Essa deixará de existir a partir da versão 2.0.0.")]
        public string accountNumber { get => AccountNumber; set => AccountNumber = value; }
        [JsonIgnore, Obsolete("Utilize a propriedade que inicia com a letra maiúscula. Essa deixará de existir a partir da versão 2.0.0.")]
        public string accountCheckNumber { get => AccountCheckNumber; set => AccountCheckNumber = value; }
        [JsonIgnore, Obsolete("Utilize a propriedade que inicia com a letra maiúscula. Essa deixará de existir a partir da versão 2.0.0.")]
        public string @type { get => Type; set => Type = value; }
        [JsonIgnore, Obsolete("Utilize a propriedade que inicia com a letra maiúscula. Essa deixará de existir a partir da versão 2.0.0.")]
        public Holder holder { get => Holder; set => Holder = value; }
    }
    public partial class BankAccountRequest
    {
        [JsonProperty("bankNumber", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string BankNumber { get; set; }
        [JsonProperty("agencyNumber", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string AgencyNumber { get; set; }
        [JsonProperty("agencyCheckNumber", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string AgencyCheckNumber { get; set; }
        [JsonProperty("accountNumber", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string AccountNumber { get; set; }
        [JsonProperty("accountCheckNumber", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string AccountCheckNumber { get; set; }
        [JsonProperty("type", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Type { get; set; }
        [JsonProperty("holder", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Holder Holder { get; set; }
    }
}
