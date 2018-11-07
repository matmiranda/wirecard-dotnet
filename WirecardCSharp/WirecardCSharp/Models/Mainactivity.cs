using System;
using Newtonsoft.Json;

namespace WirecardCSharp.Models
{
    public partial class Mainactivity
    {
        [Obsolete("Utilize a propriedade que inicia com a letra maiúscula. Essa deixará de existir a partir da versão 2.0.0.")]
        public string cnae { get => Cnae; set => value = Cnae; }
        [Obsolete("Utilize a propriedade que inicia com a letra maiúscula. Essa deixará de existir a partir da versão 2.0.0.")]
        public string description { get => Description; set => value = Description; }
    }
    public partial class Mainactivity
    {
        [JsonProperty("cnae", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Cnae { get; set; }
        [JsonProperty("description", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Description { get; set; }
    }
}
