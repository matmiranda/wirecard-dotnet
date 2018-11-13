using System;
using Newtonsoft.Json;

namespace WirecardCSharp.Models
{
    public partial class Payboleto
    {
        [JsonIgnore, Obsolete("Utilize a propriedade que inicia com a letra maiúscula. Essa deixará de existir a partir da versão 2.0.0.")]
        public string redirectHref { get => RedirectHref; set => RedirectHref = value; }
    }
    public partial class Payboleto
    {
        [JsonProperty("printHref", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string PrintHref { get; set; }
        [JsonProperty("redirectHref", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string RedirectHref { get; set; }
    }
}
