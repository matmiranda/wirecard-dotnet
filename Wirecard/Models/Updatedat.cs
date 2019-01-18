using System;
using Newtonsoft.Json;

namespace Wirecard.Models
{
    public class Updatedat
    {
        [JsonProperty("$date", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public DateTime Date { get; set; }
    }
}