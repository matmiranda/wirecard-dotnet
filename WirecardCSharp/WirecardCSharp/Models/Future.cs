using System;
using Newtonsoft.Json;

namespace WirecardCSharp.Models
{
    public partial class Future
    {
        [JsonIgnore, Obsolete("Utilize a propriedade que inicia com a letra maiúscula. Essa deixará de existir a partir da versão 2.0.0.")]
        public int amount { get => Amount; set => Amount = value; }
        [JsonIgnore, Obsolete("Utilize a propriedade que inicia com a letra maiúscula. Essa deixará de existir a partir da versão 2.0.0.")]
        public string currency { get => Currency; set => Currency = value; }
    }
    public partial class Future
    {
        [JsonProperty("amount", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int Amount { get; set; }
        [JsonProperty("currency", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Currency { get; set; }
    }
}
