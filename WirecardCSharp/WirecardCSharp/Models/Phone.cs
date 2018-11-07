using System;
using Newtonsoft.Json;

namespace WirecardCSharp.Models
{
    public partial class Phone
    {
        [Obsolete("Utilize a propriedade que inicia com a letra maiúscula. Essa deixará de existir a partir da versão 2.0.0.")]
        public string countryCode { get => CountryCode; set => value = CountryCode; }
        [Obsolete("Utilize a propriedade que inicia com a letra maiúscula. Essa deixará de existir a partir da versão 2.0.0.")]
        public string areaCode { get => AreaCode; set => value = AreaCode; }
        [Obsolete("Utilize a propriedade que inicia com a letra maiúscula. Essa deixará de existir a partir da versão 2.0.0.")]
        public string number { get => Number; set => value = Number; }
    }
    public partial class Phone
    {
        [JsonProperty("countryCode", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string CountryCode { get; set; }
        [JsonProperty("areaCode", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string AreaCode { get; set; }
        [JsonProperty("number", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Number { get; set; }
    }
}
