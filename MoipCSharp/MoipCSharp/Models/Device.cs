#pragma warning disable IDE1006

namespace MoipCSharp.Models
{
    public class Device
    {
        public string ip { get; set; }
        public Geolocation geolocation { get; set; }
        public string userAgent { get; set; }
        public string fingerprint { get; set; }
    }
}
