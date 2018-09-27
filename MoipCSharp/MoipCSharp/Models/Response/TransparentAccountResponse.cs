using System;
#pragma warning disable IDE1006

namespace MoipCSharp.Models
{
    public class TransparentAccountResponse
    {
        public string id { get; set; }
        public string login { get; set; }
        public string accessToken { get; set; }
        public string channelId { get; set; }
        public string type { get; set; }
        public bool transparentAccount { get; set; }
        public Email email { get; set; }
        public Person person { get; set; }
        public DateTime createdAt { get; set; }
        public _Links _links { get; set; }
    }
}
