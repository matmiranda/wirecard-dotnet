using System;
using Newtonsoft.Json;

namespace WirecardCSharp.Models
{
    public partial class Businesssegment
    {
        [Obsolete("Utilize a propriedade que inicia com a letra maiúscula. Essa deixará de existir a partir da versão 2.0.0.")]
        public int id { get => Id; set => Id = value; }
    }
    public partial class Businesssegment
    {
        [JsonProperty("id", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int Id { get; set; }
    }
}
