using Newtonsoft.Json;

namespace TornAPI.MarketData;

public class Bazaar {
	[JsonProperty("bazaar")]
	public Dictionary<long, Item> BazaarItems { get; set; }
}