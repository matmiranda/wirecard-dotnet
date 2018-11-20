using Newtonsoft.Json;

namespace WirecardCSharp.Models
{
    public class Id
    {
        [JsonProperty("$oid", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Oid { get; set; }
    }
}