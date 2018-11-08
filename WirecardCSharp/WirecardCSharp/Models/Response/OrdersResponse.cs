using System;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace WirecardCSharp.Models
{
    public partial class OrdersResponse
    {
        [Obsolete("Utilize a propriedade que inicia com a letra maiúscula. Essa deixará de existir a partir da versão 2.0.0.")]
        public _Links _links { get => _Links; set => _Links = value; }
        [Obsolete("Utilize a propriedade que inicia com a letra maiúscula. Essa deixará de existir a partir da versão 2.0.0.")]
        public Summary summary { get => Summary; set => Summary = value; }
        [Obsolete("Utilize a propriedade que inicia com a letra maiúscula. Essa deixará de existir a partir da versão 2.0.0.")]
        public List<Order> orders { get => Orders; set => Orders = value; }
    }
    public partial class OrdersResponse
    {
        [JsonProperty("_links", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public _Links _Links { get; set; }
        [JsonProperty("summary", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Summary Summary { get; set; }
        [JsonProperty("orders", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public List<Order> Orders { get; set; }
    }
}
