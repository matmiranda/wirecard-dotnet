using System;
#pragma warning disable IDE1006

namespace MoipCSharp.Models
{
    public class Webhook
    {
        public string id { get; set; }
        public string resourceId { get; set; }
        public string _event { get; set; }
        public string url { get; set; }
        public string status { get; set; }
        public DateTime sentAt { get; set; }
    }
}
