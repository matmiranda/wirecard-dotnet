using System;
using Newtonsoft.Json;

namespace WirecardCSharp.Models
{
    public partial class BalanceResponse
    {
        [JsonIgnore, Obsolete("Utilize a propriedade que inicia com a letra maiúscula. Essa deixará de existir a partir da versão 2.0.0.")]
        public int unavailable { get => Unavailable; set => Unavailable = value; }
        [JsonIgnore, Obsolete("Utilize a propriedade que inicia com a letra maiúscula. Essa deixará de existir a partir da versão 2.0.0.")]
        public int future { get => Future; set => Future = value; }
        [JsonIgnore, Obsolete("Utilize a propriedade que inicia com a letra maiúscula. Essa deixará de existir a partir da versão 2.0.0.")]
        public int current { get => Current; set => Current = value; }
        [JsonIgnore, Obsolete("Utilize a propriedade que inicia com a letra maiúscula. Essa deixará de existir a partir da versão 2.0.0.")]
        public _Links _links { get => _Links; set => _Links = value; }
        [JsonIgnore, Obsolete("Utilize a propriedade que inicia com a letra maiúscula. Essa deixará de existir a partir da versão 2.0.0.")]
        public string date { get => Date; set => Date = value; }
    }
    public partial class BalanceResponse
    {
        [JsonProperty("unavailable", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int Unavailable { get; set; }
        [JsonProperty("future", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int Future { get; set; }
        [JsonProperty("current", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int Current { get; set; }
        [JsonProperty("_links", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public _Links _Links { get; set; }
        [JsonProperty("date", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Date { get; set; }
    }
}
