using System;
using Newtonsoft.Json;

namespace WirecardCSharp.Models
{
    public partial class Onlinebankdebit
    {
        [JsonIgnore, Obsolete("Utilize a propriedade que inicia com a letra maiúscula. Essa deixará de existir a partir da versão 2.0.0.")]
        public string bankNumber { get => BankNumber; set => BankNumber = value; }
        [JsonIgnore, Obsolete("Utilize a propriedade que inicia com a letra maiúscula. Essa deixará de existir a partir da versão 2.0.0.")]
        public string expirationDate { get => ExpirationDate; set => ExpirationDate = value; }
        [JsonIgnore, Obsolete("Utilize a propriedade que inicia com a letra maiúscula. Essa deixará de existir a partir da versão 2.0.0.")]
        public string bankName { get => BankName; set => BankName = value; }
    }
    public partial class Onlinebankdebit
    {
        [JsonProperty("bankNumber", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string BankNumber { get; set; }
        [JsonProperty("expirationDate", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string ExpirationDate { get; set; }
        [JsonProperty("bankName", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string BankName { get; set; }
        [JsonProperty("returnUri", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string ReturnUri { get; set; }
    }
}
