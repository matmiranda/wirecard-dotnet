using System;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace WirecardCSharp.Models
{
    public partial class Checkoutpreferences
    {
        [Obsolete("Utilize a propriedade que inicia com a letra maiúscula. Essa deixará de existir a partir da versão 2.0.0.")]
        public List<Installment> installments { get => Installments; set => value = Installments; }
        [Obsolete("Utilize a propriedade que inicia com a letra maiúscula. Essa deixará de existir a partir da versão 2.0.0.")]
        public Redirecturls redirectUrls { get => RedirectUrls; set => value = RedirectUrls; }
    }
    public partial class Checkoutpreferences
    {
        [JsonProperty("installments", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public List<Installment> Installments { get; set; }
        [JsonProperty("redirectUrls", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Redirecturls RedirectUrls { get; set; }
    }
}
