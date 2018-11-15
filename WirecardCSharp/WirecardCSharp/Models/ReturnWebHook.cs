using Newtonsoft.Json;

namespace WirecardCSharp.Models
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
    }
}