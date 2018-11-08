using System;
using Newtonsoft.Json;

namespace WirecardCSharp.Models
{
    public partial class Redirecturls
    {
        [Obsolete("Utilize a propriedade que inicia com a letra maiúscula. Essa deixará de existir a partir da versão 2.0.0.")]
        public string urlFailure { get => UrlFailure; set => UrlFailure = value; }
        [Obsolete("Utilize a propriedade que inicia com a letra maiúscula. Essa deixará de existir a partir da versão 2.0.0.")]
        public string urlSuccess { get => UrlSuccess; set => UrlSuccess = value; }
    }
    public partial class Redirecturls
    {
        [JsonProperty("urlFailure", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string UrlFailure { get; set; }
        [JsonProperty("urlSuccess", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string UrlSuccess { get; set; }
    }
}
