using System;
using Newtonsoft.Json;

namespace WirecardCSharp.Models
{
    public partial class Email
    {
        [Obsolete("Utilize a propriedade que inicia com a letra maiúscula. Essa deixará de existir a partir da versão 2.0.0.")]
        public string address { get => Address; set => value = Address; }
        [Obsolete("Utilize a propriedade que inicia com a letra maiúscula. Essa deixará de existir a partir da versão 2.0.0.")]
        public bool confirmed { get => Confirmed; set => value = Confirmed; }
    }
    public partial class Email
    {
        [JsonProperty("address", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Address { get; set; }
        [JsonProperty("confirmed", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool Confirmed { get; set; }
    }
}
