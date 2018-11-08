using System;
using Newtonsoft.Json;

namespace WirecardCSharp.Models
{
    public partial class AccessTokenResponse
    {
        [Obsolete("Utilize a propriedade que inicia com a letra maiúscula. Essa deixará de existir a partir da versão 2.0.0.")]
        public string accessToken { get => AccessToken; set => AccessToken = value; }
        [Obsolete("Utilize a propriedade que inicia com a letra maiúscula. Essa deixará de existir a partir da versão 2.0.0.")]
        public string access_token { get => Access_Token; set => Access_Token = value; }
        [Obsolete("Utilize a propriedade que inicia com a letra maiúscula. Essa deixará de existir a partir da versão 2.0.0.")]
        public string expires_in { get => Expires_In; set => Expires_In = value; }
        [Obsolete("Utilize a propriedade que inicia com a letra maiúscula. Essa deixará de existir a partir da versão 2.0.0.")]
        public string refreshToken { get => RefreshToken; set => RefreshToken = value; }
        [Obsolete("Utilize a propriedade que inicia com a letra maiúscula. Essa deixará de existir a partir da versão 2.0.0.")]
        public string refresh_token { get => Refresh_Token; set => Refresh_Token = value; }
        [Obsolete("Utilize a propriedade que inicia com a letra maiúscula. Essa deixará de existir a partir da versão 2.0.0.")]
        public string scope { get => Scope; set => Scope = value; }
        [Obsolete("Utilize a propriedade que inicia com a letra maiúscula. Essa deixará de existir a partir da versão 2.0.0.")]
        public Moipaccount moipAccount { get => MoipAccount; set => MoipAccount = value; }
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
