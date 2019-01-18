using Newtonsoft.Json;

namespace Wirecard.Models
{
    public class AccessTokenResponse
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