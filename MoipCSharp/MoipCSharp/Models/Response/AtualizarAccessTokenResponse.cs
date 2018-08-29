#pragma warning disable IDE1006

namespace MoipCSharp.Models
{
    public class AtualizarAccessTokenResponse
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
