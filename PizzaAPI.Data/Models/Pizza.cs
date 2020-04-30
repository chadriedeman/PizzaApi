using Newtonsoft.Json;
using System.Collections.Generic;

namespace PizzaAPI.Data.Models
{
    [JsonObject(MemberSerialization.OptIn)]
    public class Pizza
    {
        public Pizza()
        {
            PizzaOrders = new HashSet<PizzaOrder>();
        }

        [JsonProperty]
        public short PizzaId { get; set; }
        [JsonProperty]
        public string Name { get; set; }
        [JsonProperty]
        public string[] Toppings { get; set; }
        [JsonProperty]
        public string Crust { get; set; }
        [JsonProperty]
        public string Sauce { get; set; }
        [JsonProperty]
        public ICollection<PizzaOrder> PizzaOrders { get; set; }
    }
}
