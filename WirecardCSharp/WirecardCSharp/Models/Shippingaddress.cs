using System;
using Newtonsoft.Json;

namespace WirecardCSharp.Models
{
    public partial class Shippingaddress
    {
        [Obsolete("Utilize a propriedade que inicia com a letra maiúscula. Essa deixará de existir a partir da versão 2.0.0.")]
        public string city { get => City; set => value = City; }
        [Obsolete("Utilize a propriedade que inicia com a letra maiúscula. Essa deixará de existir a partir da versão 2.0.0.")]
        public string complement { get => Complement; set => value = Complement; }
        [Obsolete("Utilize a propriedade que inicia com a letra maiúscula. Essa deixará de existir a partir da versão 2.0.0.")]
        public string district { get => District; set => value = District; }
        [Obsolete("Utilize a propriedade que inicia com a letra maiúscula. Essa deixará de existir a partir da versão 2.0.0.")]
        public string street { get => Street; set => value = Street; }
        [Obsolete("Utilize a propriedade que inicia com a letra maiúscula. Essa deixará de existir a partir da versão 2.0.0.")]
        public string streetNumber { get => StreetNumber; set => value = StreetNumber; }
        [Obsolete("Utilize a propriedade que inicia com a letra maiúscula. Essa deixará de existir a partir da versão 2.0.0.")]
        public string zipCode { get => ZipCode; set => value = ZipCode; }
        [Obsolete("Utilize a propriedade que inicia com a letra maiúscula. Essa deixará de existir a partir da versão 2.0.0.")]
        public string state { get => State; set => value = State; }
        [Obsolete("Utilize a propriedade que inicia com a letra maiúscula. Essa deixará de existir a partir da versão 2.0.0.")]
        public string country { get => Country; set => value = Country; }
    }
    public partial class Shippingaddress
    {
        [JsonProperty("city", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string City { get; set; }
        [JsonProperty("complement", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Complement { get; set; }
        [JsonProperty("district", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string District { get; set; }
        [JsonProperty("street", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Street { get; set; }
        [JsonProperty("streetNumber", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string StreetNumber { get; set; }
        [JsonProperty("zipCode", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string ZipCode { get; set; }
        [JsonProperty("state", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string State { get; set; }
        [JsonProperty("country", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Country { get; set; }
    }
}
