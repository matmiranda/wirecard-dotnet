using System;
using Newtonsoft.Json;

namespace WirecardCSharp.Models
{
    public class Updatedat
    {
        [JsonProperty("$date", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public DateTime Date { get; set; }
    }
}