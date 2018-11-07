using System;
using Newtonsoft.Json;

namespace WirecardCSharp.Models
{
    public partial class Card
    {
        [Obsolete("Utilize a propriedade que inicia com a letra maiúscula. Essa deixará de existir a partir da versão 2.0.0.")]
        public string brand { get => Brand; set => value = Brand; }
        [Obsolete("Utilize a propriedade que inicia com a letra maiúscula. Essa deixará de existir a partir da versão 2.0.0.")]
        public bool store { get => Store; set => value = Store; }
    }
    public partial class Card
    {
        [JsonProperty("brand", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Brand { get; set; }
        [JsonProperty("store", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool Store { get; set; }
    }
}
