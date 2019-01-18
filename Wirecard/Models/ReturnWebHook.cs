using Newtonsoft.Json;

namespace Wirecard.Models
{
    public class ReturnWebHook
    {
        [JsonProperty("date", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Date { get; set; }
        [JsonProperty("env", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Env { get; set; }
        [JsonProperty("event", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Event { get; set; }
        [JsonProperty("resource", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Resource Resource { get; set; }
        [JsonProperty("_id", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Id Id { get; set; }
        [JsonProperty("_class", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string _Class { get; set; }
        [JsonProperty("externalId", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string ExternalId { get; set; }
        [JsonProperty("resourceId", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string ResourceId { get; set; }
        [JsonProperty("accountId", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string AccountId { get; set; }
        [JsonProperty("channelId", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string ChannelId { get; set; }
        [JsonProperty("url", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Url { get; set; }
        [JsonProperty("token", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Token { get; set; }
        [JsonProperty("status", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Status { get; set; }
        [JsonProperty("response", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Response Response { get; set; }
        [JsonProperty("createdAt", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Createdat CreatedAt { get; set; }
        [JsonProperty("updatedAt", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Updatedat UpdatedAt { get; set; }
        [JsonProperty("webhookToFire", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Webhooktofire WebhookToFire { get; set; }
    }
}