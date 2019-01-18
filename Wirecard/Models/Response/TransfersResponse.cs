using Newtonsoft.Json;
using System.Collections.Generic;

namespace Wirecard.Models
{
    public class TransfersResponse
    {
        [JsonProperty("summary", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Summary Summary { get; set; }
        [JsonProperty("transfers", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public List<Transfer> Transfers { get; set; }
        [JsonProperty("_links", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public _Links _Links { get; set; }
    }
}