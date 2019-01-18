using Newtonsoft.Json;

namespace Wirecard.Models
{
    public class Boleto
    {
        [JsonProperty("expirationDate", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string ExpirationDate { get; set; }
        [JsonProperty("instructionLines", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Instructionlines InstructionLines { get; set; }
        [JsonProperty("logoUri", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string LogoUri { get; set; }
        [JsonProperty("lineCode", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string LineCode { get; set; }
    }
}