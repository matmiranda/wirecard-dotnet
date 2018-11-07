using System;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace WirecardCSharp.Models
{
    public partial class NotificationResponse
    {
        [Obsolete("Utilize a propriedade que inicia com a letra maiúscula. Essa deixará de existir a partir da versão 2.0.0.")]
        public List<string> events { get => Events; set => value = Events; }
        [Obsolete("Utilize a propriedade que inicia com a letra maiúscula. Essa deixará de existir a partir da versão 2.0.0.")]
        public string target { get => Target; set => value = Target; }
        [Obsolete("Utilize a propriedade que inicia com a letra maiúscula. Essa deixará de existir a partir da versão 2.0.0.")]
        public string media { get => Media; set => value = Media; }
        [Obsolete("Utilize a propriedade que inicia com a letra maiúscula. Essa deixará de existir a partir da versão 2.0.0.")]
        public string token { get => Token; set => value = Token; }
        [Obsolete("Utilize a propriedade que inicia com a letra maiúscula. Essa deixará de existir a partir da versão 2.0.0.")]
        public string id { get => Id; set => value = Id; }
    }
    public partial class NotificationResponse
    {
        [JsonProperty("events", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public List<string> Events { get; set; }
        [JsonProperty("target", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Target { get; set; }
        [JsonProperty("media", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Media { get; set; }
        [JsonProperty("token", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Token { get; set; }
        [JsonProperty("id", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Id { get; set; }
    }
}
