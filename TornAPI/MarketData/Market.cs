using Newtonsoft.Json;

namespace TornAPI.MarketData;

public class Market {
	[JsonProperty("itemmarket")]
	public Item[] MarketItems { get; set; } = [];

	[JsonProperty("bazaar")]
	public Item[] BazaarItems { get; set; } = [];
}