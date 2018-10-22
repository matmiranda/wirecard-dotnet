using System.Collections.Generic;

namespace WirecardCSharp.Models
{
    public class NotificationRequest
    {
        public List<string> events { get; set; }
        public string target { get; set; }
        public string media { get; set; }
    }
}
