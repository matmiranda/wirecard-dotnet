using System;
using Newtonsoft.Json;

namespace WirecardCSharp.Models
{
    public partial class Fee
    {
        [Obsolete("Utilize a propriedade que inicia com a letra maiúscula. Essa deixará de existir a partir da versão 2.0.0.")]
        public string type { get => Type; set => value = Type; }
        [Obsolete("Utilize a propriedade que inicia com a letra maiúscula. Essa deixará de existir a partir da versão 2.0.0.")]
        public int amount { get => Amount; set => value = Amount; }
    }
    public partial class Fee
    {
        [JsonProperty("type", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Type { get; set; }
        [JsonProperty("amount", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int Amount { get; set; }
    }
}
