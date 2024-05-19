using Newtonsoft.Json;

namespace TornAPI.MarketData;

public class Item {
    [JsonProperty("cost")]
    public int Cost { get; set; }

    [JsonProperty("quantity")]
    public int Quantity { get; set; }
}