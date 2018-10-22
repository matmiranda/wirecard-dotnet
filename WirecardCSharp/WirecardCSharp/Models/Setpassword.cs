using Newtonsoft.Json;

namespace WirecardCSharp.Models
{
    public class Setpassword
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string href { get; set; }
    }
}