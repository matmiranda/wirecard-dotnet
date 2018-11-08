using System;
using Newtonsoft.Json;

namespace WirecardCSharp.Models
{
    public partial class Item
    {
        [Obsolete("Utilize a propriedade que inicia com a letra maiúscula. Essa deixará de existir a partir da versão 2.0.0.")]
        public string product { get => Product; set => Product = value; }
        [Obsolete("Utilize a propriedade que inicia com a letra maiúscula. Essa deixará de existir a partir da versão 2.0.0.")]
        public string category { get => Category; set => Category = value; }
        [Obsolete("Utilize a propriedade que inicia com a letra maiúscula. Essa deixará de existir a partir da versão 2.0.0.")]
        public int quantity { get => Quantity; set => Quantity = value; }
        [Obsolete("Utilize a propriedade que inicia com a letra maiúscula. Essa deixará de existir a partir da versão 2.0.0.")]
        public string detail { get => Detail; set => Detail = value; }
        [Obsolete("Utilize a propriedade que inicia com a letra maiúscula. Essa deixará de existir a partir da versão 2.0.0.")]
        public int price { get => Price; set => Price = value; }
    }
    public partial class Item
    {
        [JsonProperty("product", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Product { get; set; }
        [JsonProperty("category", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Category { get; set; }
        [JsonProperty("quantity", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int Quantity { get; set; }
        [JsonProperty("detail", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Detail { get; set; }
        [JsonProperty("price", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int Price { get; set; }
    }
}
