using Newtonsoft.Json;
using System.Collections.Generic;

namespace Wirecard.Models
{
    public class PlansResponse
    {
        [JsonProperty("plans", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public List<Plan> Plans { get; set; }
    }
}