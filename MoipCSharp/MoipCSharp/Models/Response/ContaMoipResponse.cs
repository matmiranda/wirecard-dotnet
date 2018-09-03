using System;
#pragma warning disable IDE1006

namespace MoipCSharp.Models
{
    public class ContaMoipResponse
    {
        public string id { get; set; }
        public Person person { get; set; }
        public bool transparentAccount { get; set; }
        public Email email { get; set; }
        public DateTime createdAt { get; set; }
        public Businesssegment businessSegment { get; set; }
        public string feeType { get; set; }
        public _Links _links { get; set; }
        public int monthlyRevenueId { get; set; }
        public string softDescriptor { get; set; }
        public string login { get; set; }
        public string type { get; set; }
    }
}
