using System;
#pragma warning disable IDE1006

namespace MoipCSharp.Models
{
    public class Event
    {
        public string type { get; set; }
        public DateTime createdAt { get; set; }
        public string description { get; set; }
    }
}
