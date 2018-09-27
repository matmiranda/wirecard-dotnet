using System.Collections.Generic;
#pragma warning disable IDE1006

namespace MoipCSharp.Models
{
    public class NotificationRequest
    {
        public List<string> events { get; set; }
        public string target { get; set; }
        public string media { get; set; }
    }
}
