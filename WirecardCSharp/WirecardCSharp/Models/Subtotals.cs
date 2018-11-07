using System;
using Newtonsoft.Json;

namespace WirecardCSharp.Models
{
    public partial class Subtotals
    {
        [Obsolete("Utilize a propriedade que inicia com a letra maiúscula. Essa deixará de existir a partir da versão 2.0.0.")]
        public int shipping { get => Shipping; set => value = Shipping; }
        [Obsolete("Utilize a propriedade que inicia com a letra maiúscula. Essa deixará de existir a partir da versão 2.0.0.")]
        public int addition { get => Addition; set => value = Addition; }
        [Obsolete("Utilize a propriedade que inicia com a letra maiúscula. Essa deixará de existir a partir da versão 2.0.0.")]
        public int discount { get => Discount; set => value = Discount; }
        [Obsolete("Utilize a propriedade que inicia com a letra maiúscula. Essa deixará de existir a partir da versão 2.0.0.")]
        public int items { get => Items; set => value = Items; }
    }
    public partial class Subtotals
    {
        [JsonProperty("shipping", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int Shipping { get; set; }
        [JsonProperty("addition", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int Addition { get; set; }
        [JsonProperty("discount", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int Discount { get; set; }
        [JsonProperty("items", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int Items { get; set; }
    }
}
