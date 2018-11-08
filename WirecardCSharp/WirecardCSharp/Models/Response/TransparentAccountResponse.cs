using System;
using Newtonsoft.Json;

namespace WirecardCSharp.Models
{
    public partial class TransparentAccountResponse
    {
        [Obsolete("Utilize a propriedade que inicia com a letra maiúscula. Essa deixará de existir a partir da versão 2.0.0.")]
        public string id { get => Id; set => Id = value; }
        [Obsolete("Utilize a propriedade que inicia com a letra maiúscula. Essa deixará de existir a partir da versão 2.0.0.")]
        public string login { get => Login; set => Login = value; }
        [Obsolete("Utilize a propriedade que inicia com a letra maiúscula. Essa deixará de existir a partir da versão 2.0.0.")]
        public string accessToken { get => AccessToken; set => AccessToken = value; }
        [Obsolete("Utilize a propriedade que inicia com a letra maiúscula. Essa deixará de existir a partir da versão 2.0.0.")]
        public string channelId { get => ChannelId; set => ChannelId = value; }
        [Obsolete("Utilize a propriedade que inicia com a letra maiúscula. Essa deixará de existir a partir da versão 2.0.0.")]
        public string type { get => Type; set => Type = value; }
        [Obsolete("Utilize a propriedade que inicia com a letra maiúscula. Essa deixará de existir a partir da versão 2.0.0.")]
        public bool transparentAccount { get => TransparentAccount; set => TransparentAccount = value; }
        [Obsolete("Utilize a propriedade que inicia com a letra maiúscula. Essa deixará de existir a partir da versão 2.0.0.")]
        public Email email { get => Email; set => Email = value; }
        [Obsolete("Utilize a propriedade que inicia com a letra maiúscula. Essa deixará de existir a partir da versão 2.0.0.")]
        public Person person { get => Person; set => Person = value; }
        [Obsolete("Utilize a propriedade que inicia com a letra maiúscula. Essa deixará de existir a partir da versão 2.0.0.")]
        public DateTime createdAt { get => CreatedAt; set => CreatedAt = value; }
        [Obsolete("Utilize a propriedade que inicia com a letra maiúscula. Essa deixará de existir a partir da versão 2.0.0.")]
        public _Links _links { get => _Links; set => _Links = value; }
    }
    public partial class TransparentAccountResponse
    {
        [JsonProperty("id", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Id { get; set; }
        [JsonProperty("login", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Login { get; set; }
        [JsonProperty("accessToken", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string AccessToken { get; set; }
        [JsonProperty("channelId", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string ChannelId { get; set; }
        [JsonProperty("type", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Type { get; set; }
        [JsonProperty("transparentAccount", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool TransparentAccount { get; set; }
        [JsonProperty("email", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Email Email { get; set; }
        [JsonProperty("person", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Person Person { get; set; }
        [JsonProperty("createdAt", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public DateTime CreatedAt { get; set; }
        [JsonProperty("_links", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public _Links _Links { get; set; }
    }
}
