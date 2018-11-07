using System;
using Newtonsoft.Json;

namespace WirecardCSharp.Models
{
    public partial class Geolocation
    {
        [Obsolete("Utilize a propriedade que inicia com a letra maiúscula. Essa deixará de existir a partir da versão 2.0.0.")]
        public float latitude { get => Latitude; set => value = Latitude; }
        [Obsolete("Utilize a propriedade que inicia com a letra maiúscula. Essa deixará de existir a partir da versão 2.0.0.")]
        public float longitude { get => Longitude; set => value = Longitude; }
    }
    public partial class Geolocation
    {
        [JsonProperty("latitude", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public float Latitude { get; set; }
        [JsonProperty("longitude", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public float Longitude { get; set; }
    }
}
