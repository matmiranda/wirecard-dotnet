using System;
using Newtonsoft.Json;

namespace WirecardCSharp.Models
{
    public partial class Summary
    {
        [JsonIgnore, Obsolete("Utilize a propriedade que inicia com a letra maiúscula. Essa deixará de existir a partir da versão 2.0.0.")]
        public int count { get => Count; set => Count = value; }
        [JsonIgnore, Obsolete("Utilize a propriedade que inicia com a letra maiúscula. Essa deixará de existir a partir da versão 2.0.0.")]
        public int amount { get => Amount; set => Amount = value; }
    }
    public partial class Summary
    {
        [JsonProperty("count", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int Count { get; set; }
        [JsonProperty("amount", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int Amount { get; set; }
    }
}
