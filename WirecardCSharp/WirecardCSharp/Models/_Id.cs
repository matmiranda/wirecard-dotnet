using Newtonsoft.Json;

namespace WirecardCSharp.Models
{
    public class _Id
    {
        [JsonProperty("oid", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Oid { get; set; }
    }
}