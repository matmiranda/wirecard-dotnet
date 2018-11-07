using System;
using Newtonsoft.Json;

namespace WirecardCSharp.Models
{
    public partial class Device
    {
        [Obsolete("Utilize a propriedade que inicia com a letra maiúscula. Essa deixará de existir a partir da versão 2.0.0.")]
        public string ip { get => Ip; set => value = Ip; }
        [Obsolete("Utilize a propriedade que inicia com a letra maiúscula. Essa deixará de existir a partir da versão 2.0.0.")]
        public Geolocation geolocation { get => Geolocation; set => value = Geolocation; }
        [Obsolete("Utilize a propriedade que inicia com a letra maiúscula. Essa deixará de existir a partir da versão 2.0.0.")]
        public string userAgent { get => UserAgent; set => value = UserAgent; }
        [Obsolete("Utilize a propriedade que inicia com a letra maiúscula. Essa deixará de existir a partir da versão 2.0.0.")]
        public string fingerprint { get => Fingerprint; set => value = Fingerprint; }
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
