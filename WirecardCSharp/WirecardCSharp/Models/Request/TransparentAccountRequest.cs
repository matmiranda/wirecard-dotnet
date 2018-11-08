using System;
using Newtonsoft.Json;

namespace WirecardCSharp.Models
{
    public partial class TransparentAccountRequest
    {
        [Obsolete("Utilize a propriedade que inicia com a letra maiúscula. Essa deixará de existir a partir da versão 2.0.0.")]
        public Email email { get => Email; set => Email = value; }
        [Obsolete("Utilize a propriedade que inicia com a letra maiúscula. Essa deixará de existir a partir da versão 2.0.0.")]
        public Person person { get => Person; set => Person = value; }
        [Obsolete("Utilize a propriedade que inicia com a letra maiúscula. Essa deixará de existir a partir da versão 2.0.0.")]
        public string type { get => Type; set => Type = value; }
        [Obsolete("Utilize a propriedade que inicia com a letra maiúscula. Essa deixará de existir a partir da versão 2.0.0.")]
        public bool transparentAccount { get => TransparentAccount; set => TransparentAccount = value; }
        [Obsolete("Utilize a propriedade que inicia com a letra maiúscula. Essa deixará de existir a partir da versão 2.0.0.")]
        public Company company { get => Company; set => Company = value; }
    }
    public partial class TransparentAccountRequest
    {
        [JsonProperty("email", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Email Email { get; set; }
        [JsonProperty("person", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Person Person { get; set; }
        [JsonProperty("type", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Type { get; set; }
        [JsonProperty("transparentAccount", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool TransparentAccount { get; set; }
        [JsonProperty("company", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Company Company { get; set; }
    }
}
