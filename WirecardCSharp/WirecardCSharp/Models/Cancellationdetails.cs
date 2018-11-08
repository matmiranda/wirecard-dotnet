using System;
using Newtonsoft.Json;

namespace WirecardCSharp.Models
{
    public partial class Cancellationdetails
    {
        [JsonIgnore, Obsolete("Utilize a propriedade que inicia com a letra maiúscula. Essa deixará de existir a partir da versão 2.0.0.")]
        public string code { get => Code; set => Code = value; }
        [JsonIgnore, Obsolete("Utilize a propriedade que inicia com a letra maiúscula. Essa deixará de existir a partir da versão 2.0.0.")]
        public string description { get => Description; set => Description = value; }
        [JsonIgnore, Obsolete("Utilize a propriedade que inicia com a letra maiúscula. Essa deixará de existir a partir da versão 2.0.0.")]
        public string cancelledBy { get => CancelledBy; set => CancelledBy = value; }
    }
    public partial class Cancellationdetails
    {
        [JsonProperty("code", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Code { get; set; }
        [JsonProperty("description", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Description { get; set; }
        [JsonProperty("cancelledBy", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string CancelledBy { get; set; }
    }
}
