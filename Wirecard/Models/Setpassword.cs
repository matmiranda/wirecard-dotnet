using System;
using Newtonsoft.Json;

namespace Wirecard.Models
{
    public class Setpassword
    {
        [JsonProperty("href", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Href { get; set; }
    }
}