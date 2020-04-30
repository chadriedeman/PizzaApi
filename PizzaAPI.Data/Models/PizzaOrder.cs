using Newtonsoft.Json;

namespace PizzaAPI.Data.Models
{
    [JsonObject(MemberSerialization.OptIn)]
    public class PizzaOrder
    {
        [JsonProperty]
        public short OrderId { get; set; }
        [JsonProperty]
        public short PizzaId { get; set; }
        [JsonProperty]
        public string Size { get; set; }
        [JsonProperty]
        public Pizza Pizza { get; set; }
    }
}
