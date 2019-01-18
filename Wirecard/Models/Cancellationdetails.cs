using Newtonsoft.Json;

namespace Wirecard.Models
{
    public class Cancellationdetails
    {
        [JsonProperty("code", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Code { get; set; }
        [JsonProperty("description", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Description { get; set; }
        [JsonProperty("cancelledBy", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string CancelledBy { get; set; }
    }
}