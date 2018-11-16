using System;
using Newtonsoft.Json;

namespace WirecardCSharp.Models
{
    public class Createdat
    {
        [JsonProperty("$date", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public DateTime Date { get; set; }
    }
}
