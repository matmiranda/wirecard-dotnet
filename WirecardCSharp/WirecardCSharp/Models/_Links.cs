using System;
using Newtonsoft.Json;

namespace WirecardCSharp.Models
{
    public partial class _Links
    {
        [Obsolete("Utilize a propriedade que inicia com a letra maiúscula. Essa deixará de existir a partir da versão 2.0.0.")]
        public Next next { get => Next; set => value = Next; }
        [Obsolete("Utilize a propriedade que inicia com a letra maiúscula. Essa deixará de existir a partir da versão 2.0.0.")]
        public Previous previous { get => Previous; set => value = Previous; }
        [Obsolete("Utilize a propriedade que inicia com a letra maiúscula. Essa deixará de existir a partir da versão 2.0.0.")]
        public Self self { get => Self; set => value = Self; }
        [Obsolete("Utilize a propriedade que inicia com a letra maiúscula. Essa deixará de existir a partir da versão 2.0.0.")]
        public Hostedaccount hostedAccount { get => HostedAccount; set => value = HostedAccount; }
        [Obsolete("Utilize a propriedade que inicia com a letra maiúscula. Essa deixará de existir a partir da versão 2.0.0.")]
        public Order order { get => Order; set => value = Order; }
        [Obsolete("Utilize a propriedade que inicia com a letra maiúscula. Essa deixará de existir a partir da versão 2.0.0.")]
        public Payment payment { get => Payment; set => value = Payment; }
        [Obsolete("Utilize a propriedade que inicia com a letra maiúscula. Essa deixará de existir a partir da versão 2.0.0.")]
        public string file { get => File; set => value = File; }
        [Obsolete("Utilize a propriedade que inicia com a letra maiúscula. Essa deixará de existir a partir da versão 2.0.0.")]
        public Setpassword setPassword { get => SetPassword; set => value = SetPassword; }
        [Obsolete("Utilize a propriedade que inicia com a letra maiúscula. Essa deixará de existir a partir da versão 2.0.0.")]
        public Checkout checkout { get => Checkout; set => value = Checkout; }
    }
    public partial class _Links
    {
        [JsonProperty("next", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Next Next { get; set; }
        [JsonProperty("previous", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Previous Previous { get; set; }
        [JsonProperty("self", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Self Self { get; set; }
        [JsonProperty("hostedAccount", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Hostedaccount HostedAccount { get; set; }
        [JsonProperty("order", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Order Order { get; set; }
        [JsonProperty("payment", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Payment Payment { get; set; }
        [JsonProperty("file", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string File { get; set; }
        [JsonProperty("setPassword", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Setpassword SetPassword { get; set; }
        [JsonProperty("checkout", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Checkout Checkout { get; set; }
    }
}
