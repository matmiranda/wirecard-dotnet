using Newtonsoft.Json;

namespace WirecardCSharp.Models
{
    public class TransparentAccountRequest
    {
        public Email email { get; set; }
        public Person person { get; set; }
        public string type { get; set; }
        public bool transparentAccount { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Company company { get; set; }
    }
}