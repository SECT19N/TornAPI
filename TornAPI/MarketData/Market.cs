using Newtonsoft.Json;

namespace TornAPI.MarketData;

public class Market {
	[JsonProperty("itemmarket")]
	public ItemMarket ItemMarket { get; set; }

	[JsonProperty("bazaar")]
	public Bazaar ItemBazaar { get; set; }
}