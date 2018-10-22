using System.Collections.Generic;

namespace WirecardCSharp.Models
{
    public class NotificationResponse
    {
        public List<string> events { get; set; }
        public string target { get; set; }
        public string media { get; set; }
        public string token { get; set; }
        public string id { get; set; }
    }
}
