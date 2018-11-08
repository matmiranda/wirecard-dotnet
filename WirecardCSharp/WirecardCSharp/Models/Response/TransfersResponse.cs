using System;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace WirecardCSharp.Models
{
    public partial class TransfersResponse
    {
        [JsonIgnore, Obsolete("Utilize a propriedade que inicia com a letra maiúscula. Essa deixará de existir a partir da versão 2.0.0.")]
        public Summary summary { get => Summary; set => Summary = value; }
        [JsonIgnore, Obsolete("Utilize a propriedade que inicia com a letra maiúscula. Essa deixará de existir a partir da versão 2.0.0.")]
        public List<Transfer> transfers { get => Transfers; set => Transfers = value; }
        [JsonIgnore, Obsolete("Utilize a propriedade que inicia com a letra maiúscula. Essa deixará de existir a partir da versão 2.0.0.")]
        public _Links _links { get => _Links; set => _Links = value; }
    }
    public partial class TransfersResponse
    {
        [JsonProperty("summary", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Summary Summary { get; set; }
        [JsonProperty("transfers", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public List<Transfer> Transfers { get; set; }
        [JsonProperty("_links", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public _Links _Links { get; set; }
    }
}
