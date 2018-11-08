using System;
using Newtonsoft.Json;

namespace WirecardCSharp.Models
{
    public partial class Subtotals
    {
        [JsonIgnore, Obsolete("Utilize a propriedade que inicia com a letra maiúscula. Essa deixará de existir a partir da versão 2.0.0.")]
        public int shipping { get => Shipping; set => Shipping = value; }
        [JsonIgnore, Obsolete("Utilize a propriedade que inicia com a letra maiúscula. Essa deixará de existir a partir da versão 2.0.0.")]
        public int addition { get => Addition; set => Addition = value; }
        [JsonIgnore, Obsolete("Utilize a propriedade que inicia com a letra maiúscula. Essa deixará de existir a partir da versão 2.0.0.")]
        public int discount { get => Discount; set => Discount = value; }
        [JsonIgnore, Obsolete("Utilize a propriedade que inicia com a letra maiúscula. Essa deixará de existir a partir da versão 2.0.0.")]
        public int items { get => Items; set => Items = value; }
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
