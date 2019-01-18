using Newtonsoft.Json;

namespace Wirecard.Models
{
    public class TransferRequest
    {
        [JsonProperty("ownId", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string OwnId { get; set; }
        [JsonProperty("amount", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int Amount { get; set; }
        [JsonProperty("description", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Description { get; set; }
        [JsonProperty("transferInstrument", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Transferinstrument TransferInstrument { get; set; }
    }
}