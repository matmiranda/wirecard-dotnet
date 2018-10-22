using System;

namespace WirecardCSharp.Models
{
    public class ClassAccountResponse
    {
        public string id { get; set; }
        public string accessToken { get; set; }
        public string channelId { get; set; }
        public string type { get; set; }
        public bool transparentAccount { get; set; }
        public DateTime createdAt { get; set; }
        public Person person { get; set; }
        public Email email { get; set; }
        public _Links _links { get; set; }
        public string login { get; set; }
        public Businesssegment businessSegment { get; set; }
        public string feeType { get; set; }
        public int monthlyRevenueId { get; set; }
        public string softDescriptor { get; set; }
        public bool limited { get; set; }
        public bool verified { get; set; }
        public Company company { get; set; }
    }
}
