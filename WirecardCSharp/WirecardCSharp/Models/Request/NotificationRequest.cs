using System;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace WirecardCSharp.Models
{
    public partial class NotificationRequest
    {
        [Obsolete("Utilize a propriedade que inicia com a letra maiúscula. Essa deixará de existir a partir da versão 2.0.0.")]
        public List<string> events { get => Events; set => value = Events; }
        [Obsolete("Utilize a propriedade que inicia com a letra maiúscula. Essa deixará de existir a partir da versão 2.0.0.")]
        public string target { get => Target; set => value = Target; }
        [Obsolete("Utilize a propriedade que inicia com a letra maiúscula. Essa deixará de existir a partir da versão 2.0.0.")]
        public string media { get => Media; set => value = Media; }
    }
    public partial class NotificationRequest
    {
        [JsonProperty("events", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public List<string> Events { get; set; }
        [JsonProperty("target", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Target { get; set; }
        [JsonProperty("media", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Media { get; set; }
    }
}
