using Newtonsoft.Json;

namespace Wirecard.Models
{
    public class Notification
    {
        [JsonProperty("webhook", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Webhook Webhook { get; set; }
        [JsonProperty("email", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Email Email { get; set; }
    }
}