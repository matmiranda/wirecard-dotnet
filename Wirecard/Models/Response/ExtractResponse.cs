using Newtonsoft.Json;
using System.Collections.Generic;

namespace Wirecard.Models
{
    public class ExtractResponse
    {
        [JsonProperty("summary", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Summary Summary { get; set; }
        [JsonProperty("lines", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public List<Line> Lines { get; set; }
        [JsonProperty("_links", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public _Links _Links { get; set; }
        [JsonProperty("entries", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public List<Entry> Entries { get; set; }
    }
}