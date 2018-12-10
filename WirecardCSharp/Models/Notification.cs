using Newtonsoft.Json;

namespace WirecardCSharp.Models
{
    public class Notification
    {
        [JsonProperty("webhook", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Webhook Webhook { get; set; }
        [JsonProperty("email", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Email Email { get; set; }
    }
}