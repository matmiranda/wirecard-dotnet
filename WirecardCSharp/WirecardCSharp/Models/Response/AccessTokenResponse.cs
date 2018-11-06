using System;
using Newtonsoft.Json;

namespace WirecardCSharp.Models
{
    public partial class AccessTokenResponse
    {
        [Obsolete("Utilize a propriedade que inicia com a letra maiúscula. Essa deixará de existir a partir da versão 2.0.0.")]
        public string accessToken { get => AccessToken; set => value = AccessToken; }
        [Obsolete("Utilize a propriedade que inicia com a letra maiúscula. Essa deixará de existir a partir da versão 2.0.0.")]
        public string access_token { get => Access_Token; set => value = Access_Token; }
        [Obsolete("Utilize a propriedade que inicia com a letra maiúscula. Essa deixará de existir a partir da versão 2.0.0.")]
        public string expires_in { get => Expires_In; set => value = Expires_In; }
        [Obsolete("Utilize a propriedade que inicia com a letra maiúscula. Essa deixará de existir a partir da versão 2.0.0.")]
        public string refreshToken { get => RefreshToken; set => value = RefreshToken; }
        [Obsolete("Utilize a propriedade que inicia com a letra maiúscula. Essa deixará de existir a partir da versão 2.0.0.")]
        public string refresh_token { get => Refresh_Token; set => value = Refresh_Token; }
        [Obsolete("Utilize a propriedade que inicia com a letra maiúscula. Essa deixará de existir a partir da versão 2.0.0.")]
        public string scope { get => Scope; set => value = Scope; }
        [Obsolete("Utilize a propriedade que inicia com a letra maiúscula. Essa deixará de existir a partir da versão 2.0.0.")]
        public Moipaccount moipAccount { get => MoipAccount; set => value = MoipAccount; }
    }
    public partial class AccessTokenResponse
    {
        [JsonProperty("accessToken", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string AccessToken { get; set; }
        [JsonProperty("access_token", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Access_Token { get; set; }
        [JsonProperty("expires_in", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Expires_In { get; set; }
        [JsonProperty("refreshToken", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string RefreshToken { get; set; }
        [JsonProperty("refresh_token", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Refresh_Token { get; set; }
        [JsonProperty("scope", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Scope { get; set; }
        [JsonProperty("moipAccount", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Moipaccount MoipAccount { get; set; }
    }
}
