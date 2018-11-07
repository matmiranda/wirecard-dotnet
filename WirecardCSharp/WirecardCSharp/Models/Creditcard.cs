using System;
using Newtonsoft.Json;

namespace WirecardCSharp.Models
{
    public partial class Creditcard
    {
        [Obsolete("Utilize a propriedade que inicia com a letra maiúscula. Essa deixará de existir a partir da versão 2.0.0.")]
        public string id { get => Id; set => value = Id; }
        [Obsolete("Utilize a propriedade que inicia com a letra maiúscula. Essa deixará de existir a partir da versão 2.0.0.")]
        public string brand { get => Brand; set => value = Brand; }
        [Obsolete("Utilize a propriedade que inicia com a letra maiúscula. Essa deixará de existir a partir da versão 2.0.0.")]
        public string first6 { get => First6; set => value = First6; }
        [Obsolete("Utilize a propriedade que inicia com a letra maiúscula. Essa deixará de existir a partir da versão 2.0.0.")]
        public string last4 { get => Last4; set => value = Last4; }
        [Obsolete("Utilize a propriedade que inicia com a letra maiúscula. Essa deixará de existir a partir da versão 2.0.0.")]
        public bool store { get => Store; set => value = Store; }
        [Obsolete("Utilize a propriedade que inicia com a letra maiúscula. Essa deixará de existir a partir da versão 2.0.0.")]
        public string expirationMonth { get => ExpirationMonth; set => value = ExpirationMonth; }
        [Obsolete("Utilize a propriedade que inicia com a letra maiúscula. Essa deixará de existir a partir da versão 2.0.0.")]
        public string expirationYear { get => ExpirationYear; set => value = ExpirationYear; }
        [Obsolete("Utilize a propriedade que inicia com a letra maiúscula. Essa deixará de existir a partir da versão 2.0.0.")]
        public string number { get => Number; set => value = Number; }
        [Obsolete("Utilize a propriedade que inicia com a letra maiúscula. Essa deixará de existir a partir da versão 2.0.0.")]
        public string cvc { get => Cvc; set => value = Cvc; }
        [Obsolete("Utilize a propriedade que inicia com a letra maiúscula. Essa deixará de existir a partir da versão 2.0.0.")]
        public Holder holder { get => Holder; set => value = Holder; }
        [Obsolete("Utilize a propriedade que inicia com a letra maiúscula. Essa deixará de existir a partir da versão 2.0.0.")]
        public string hash { get => Hash; set => value = Hash; }
        [Obsolete("Utilize a propriedade que inicia com a letra maiúscula. Essa deixará de existir a partir da versão 2.0.0.")]
        public Phone phone { get => Phone; set => value = Phone; }
    }
    public partial class Creditcard
    {
        [JsonProperty("id", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Id { get; set; }
        [JsonProperty("brand", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Brand { get; set; }
        [JsonProperty("first6", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string First6 { get; set; }
        [JsonProperty("last4", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Last4 { get; set; }
        [JsonProperty("store", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool Store { get; set; }
        [JsonProperty("expirationMonth", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string ExpirationMonth { get; set; }
        [JsonProperty("expirationYear", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string ExpirationYear { get; set; }
        [JsonProperty("number", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Number { get; set; }
        [JsonProperty("cvc", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Cvc { get; set; }
        [JsonProperty("holder", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Holder Holder { get; set; }
        [JsonProperty("hash", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Hash { get; set; }
        [JsonProperty("phone", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Phone Phone { get; set; }
    }
}
