using Newtonsoft.Json;
using System.Collections.Generic;

namespace Wirecard.Models
{
    public class CouponsResponse
    {
        [JsonProperty("coupons", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public List<Coupon> Coupons { get; set; }
    }
}