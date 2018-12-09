using Newtonsoft.Json;
using System.Collections.Generic;

namespace WirecardCSharp.Models
{
    public class CouponsResponse
    {
        [JsonProperty("coupons", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public List<Coupon> Coupons { get; set; }
    }
}