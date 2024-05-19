using Newtonsoft.Json;

namespace TornAPI.MarketData;

public class ItemMarket {
    [JsonProperty("itemmarket")]
    public Dictionary<long, Item> MarketItems { get; set; }
}