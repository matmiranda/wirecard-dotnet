using System;
using Newtonsoft.Json;

namespace Wirecard.Models
{
    public class ClassAccountResponse
    {
        [JsonProperty("id", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Id { get; set; }
        [JsonProperty("accessToken", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string AccessToken { get; set; }
        [JsonProperty("channelId", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string ChannelId { get; set; }
        [JsonProperty("type", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Type { get; set; }
        [JsonProperty("transparentAccount", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool TransparentAccount { get; set; }
        [JsonProperty("createdAt", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public DateTime CreatedAt { get; set; }
        [JsonProperty("person", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Person Person { get; set; }
        [JsonProperty("email", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Email Email { get; set; }
        [JsonProperty("_links", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public _Links _Links { get; set; }
        [JsonProperty("login", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Login { get; set; }
        [JsonProperty("businessSegment", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Businesssegment BusinessSegment { get; set; }
        [JsonProperty("feeType", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string FeeType { get; set; }
        [JsonProperty("monthlyRevenueId", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int MonthlyRevenueId { get; set; }
        [JsonProperty("softDescriptor", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string SoftDescriptor { get; set; }
        [JsonProperty("limited", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool Limited { get; set; }
        [JsonProperty("verified", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool Verified { get; set; }
        [JsonProperty("company", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Company Company { get; set; }
    }
}