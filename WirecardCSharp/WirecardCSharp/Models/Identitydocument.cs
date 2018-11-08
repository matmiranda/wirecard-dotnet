using System;
using Newtonsoft.Json;

namespace WirecardCSharp.Models
{
    public partial class Identitydocument
    {
        [Obsolete("Utilize a propriedade que inicia com a letra maiúscula. Essa deixará de existir a partir da versão 2.0.0.")]
        public string type { get => Type; set => Type = value; }
        [Obsolete("Utilize a propriedade que inicia com a letra maiúscula. Essa deixará de existir a partir da versão 2.0.0.")]
        public string number { get => Number; set => Number = value; }
        [Obsolete("Utilize a propriedade que inicia com a letra maiúscula. Essa deixará de existir a partir da versão 2.0.0.")]
        public string issuer { get => Issuer; set => Issuer = value; }
        [Obsolete("Utilize a propriedade que inicia com a letra maiúscula. Essa deixará de existir a partir da versão 2.0.0.")]
        public string issueDate { get => IssueDate; set => IssueDate = value; }
    }
    public partial class Identitydocument
    {
        [JsonProperty("type", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Type { get; set; }
        [JsonProperty("number", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Number { get; set; }
        [JsonProperty("issuer", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Issuer { get; set; }
        [JsonProperty("issueDate", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string IssueDate { get; set; }
    }
}
