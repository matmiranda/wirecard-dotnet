using System;
using Newtonsoft.Json;

namespace WirecardCSharp.Models
{
    public partial class Basicauth
    {
        [Obsolete("Utilize a propriedade que inicia com a letra maiúscula. Essa deixará de existir a partir da versão 2.0.0.")]
        public string secret { get => Secret; set => value = Secret; }
        [Obsolete("Utilize a propriedade que inicia com a letra maiúscula. Essa deixará de existir a partir da versão 2.0.0.")]
        public string token { get => Token; set => value = Token; }
    }
    public partial class Basicauth
    {
        [JsonProperty("secret", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Secret { get; set; }
        [JsonProperty("token", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Token { get; set; }
    }
}
