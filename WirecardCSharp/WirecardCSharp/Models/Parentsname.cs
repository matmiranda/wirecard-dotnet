using System;
using Newtonsoft.Json;

namespace WirecardCSharp.Models
{
    public partial class Parentsname
    {
        [Obsolete("Utilize a propriedade que inicia com a letra maiúscula. Essa deixará de existir a partir da versão 2.0.0.")]
        public string mother { get => Mother; set => Mother = value; }
        [Obsolete("Utilize a propriedade que inicia com a letra maiúscula. Essa deixará de existir a partir da versão 2.0.0.")]
        public string father { get => Father; set => Father = value; }
    }
    public partial class Parentsname
    {
        [JsonProperty("mother", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Mother { get; set; }
        [JsonProperty("father", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Father { get; set; }
    }
}
