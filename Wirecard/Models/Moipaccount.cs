using Newtonsoft.Json;

namespace Wirecard.Models
{
    public class Moipaccount
    {
        [JsonProperty("id", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Id { get; set; }
        [JsonProperty("login", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Login { get; set; }
        [JsonProperty("fullname", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string FullName { get; set; }
        [JsonProperty("account", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Account { get; set; }
        [JsonProperty("email", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Email { get; set; }
    }
}