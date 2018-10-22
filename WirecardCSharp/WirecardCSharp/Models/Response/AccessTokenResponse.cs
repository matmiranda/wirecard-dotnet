namespace WirecardCSharp.Models
{
    public class AccessTokenResponse
    {
        public string accessToken { get; set; }
        public string access_token { get; set; }
        public string expires_in { get; set; }
        public string refreshToken { get; set; }
        public string refresh_token { get; set; }
        public string scope { get; set; }
        public Moipaccount moipAccount { get; set; }
    }
}