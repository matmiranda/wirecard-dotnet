using System;
#pragma warning disable IDE1006

namespace MoipCSharp.Models
{
    public class CustodiaResponse
    {
        public string id { get; set; }
        public string status { get; set; }
        public string description { get; set; }
        public int amount { get; set; }
        public DateTime createdAt { get; set; }
        public DateTime updatedAt { get; set; }
        public _Links _links { get; set; }
    }
}