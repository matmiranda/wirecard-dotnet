using System;
using Newtonsoft.Json;

namespace WirecardCSharp.Models
{
    public partial class Keys
    {
        [Obsolete("Utilize a propriedade que inicia com a letra maiúscula. Essa deixará de existir a partir da versão 2.0.0.")]
        public Basicauth basicAuth { get => BasicAuth; set => BasicAuth = value; }
        [Obsolete("Utilize a propriedade que inicia com a letra maiúscula. Essa deixará de existir a partir da versão 2.0.0.")]
        public string encryption { get => Encryption; set => Encryption = value; }
    }
    public partial class Keys
    {
        [JsonProperty("basicAuth", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Basicauth BasicAuth { get; set; }
        [JsonProperty("encryption", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Encryption { get; set; }
    }
}
