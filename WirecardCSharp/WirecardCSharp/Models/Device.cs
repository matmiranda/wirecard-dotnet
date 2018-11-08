using System;
using Newtonsoft.Json;

namespace WirecardCSharp.Models
{
    public partial class Device
    {
        [JsonIgnore, Obsolete("Utilize a propriedade que inicia com a letra maiúscula. Essa deixará de existir a partir da versão 2.0.0.")]
        public string ip { get => Ip; set => Ip = value; }
        [JsonIgnore, Obsolete("Utilize a propriedade que inicia com a letra maiúscula. Essa deixará de existir a partir da versão 2.0.0.")]
        public Geolocation geolocation { get => Geolocation; set => Geolocation = value; }
        [JsonIgnore, Obsolete("Utilize a propriedade que inicia com a letra maiúscula. Essa deixará de existir a partir da versão 2.0.0.")]
        public string userAgent { get => UserAgent; set => UserAgent = value; }
        [JsonIgnore, Obsolete("Utilize a propriedade que inicia com a letra maiúscula. Essa deixará de existir a partir da versão 2.0.0.")]
        public string fingerprint { get => Fingerprint; set => Fingerprint = value; }
    }
    public partial class Device
    {
        [JsonProperty("ip", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Ip { get; set; }
        [JsonProperty("geolocation", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Geolocation Geolocation { get; set; }
        [JsonProperty("userAgent", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string UserAgent { get; set; }
        [JsonProperty("fingerprint", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Fingerprint { get; set; }
    }
}
