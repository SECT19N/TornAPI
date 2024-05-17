using Newtonsoft.Json;

namespace TornAPI.UserData;

public class User {
    [JsonProperty("rank")]
    public string Rank { get; set; }

    [JsonProperty("level")]
    public int Level { get; set; }

    [JsonProperty("honor")]
    public int Honor { get; set; }

    [JsonProperty("gender")]
    public string Gender { get; set; }

    [JsonProperty("property")]
    public string Property { get; set; }

    [JsonProperty("signup")]
    public string SignUp { get; set; }

    [JsonProperty("awards")]
    public int Awards { get; set; }

    [JsonProperty("friends")]
    public int Friends { get; set; }

    [JsonProperty("enemies")]
    public int Enemies { get; set; }

    [JsonProperty("forum_posts")]
    public int ForumPosts { get; set; }

    [JsonProperty("server_time")]
	public int ServerTime { get; set; }

	[JsonProperty("timestamp")]
	public int CurrentTime { get; set; }

	[JsonProperty("strength")]
	public int Strength { get; set; }

	[JsonProperty("speed")]
	public int Speed { get; set; }

	[JsonProperty("dexterity")]
	public int Dexterity { get; set; }

	[JsonProperty("defense")]
	public int Defense { get; set; }

	[JsonProperty("strength_modifier")]
	public int StrengthModifier { get; set; }

	[JsonProperty("speed_modifier")]
	public int SpeedModifier { get; set; }

	[JsonProperty("dexterity_modifier")]
	public int DexterityModifier { get; set; }

	[JsonProperty("defense_modifier")]
	public int DefenseModifier { get; set; }

	[JsonProperty("networth")]
	public Networth Networth { get; set; }

	[JsonProperty("happy")]
	public Bar Happy { get; set; } = new Bar();

	[JsonProperty("life")]
	public Bar Life { get; set; } = new Bar();

	[JsonProperty("energy")]
	public Bar Energy { get; set; } = new Bar();

	[JsonProperty("nerve")]
	public Bar Nerve { get; set; } = new Bar();

	[JsonProperty("chain")]
	public Bar Chain { get; set; } = new Bar();

	[JsonProperty("cooldowns")]
	public Cooldown Cooldowns { get; set; } = new Cooldown();

	[JsonProperty("travel")]
	public Travel Travel { get; set; } = new Travel();

	[JsonProperty("criminalrecord")]
	public CriminalRecord Crimes { get; set; } = new CriminalRecord();
}

public class Networth {
	[JsonProperty("total")]
	public long Total { get; set; }

	[JsonProperty("pending")]
	public long Pending { get; set; }

	[JsonProperty("wallet")]
	public long Wallet { get; set; }

	[JsonProperty("bank")]
	public long Bank { get; set; }

	[JsonProperty("cayman")]
	public long Cayman { get; set; }

	[JsonProperty("points")]
	public long Points { get; set; }

	[JsonProperty("vault")]
	public long Vault { get; set; }

	[JsonProperty("piggybank")]
	public long PiggyBank { get; set; }

	[JsonProperty("items")]
	public long Items { get; set; }

	[JsonProperty("displaycase")]
	public long DisplayCase { get; set; }

	[JsonProperty("bazaar")]
	public long Bazaar { get; set; }

	[JsonProperty("trade")]
	public long Trade { get; set; }

	[JsonProperty("itemmarket")]
	public long ItemMarket { get; set; }

	[JsonProperty("properties")]
	public long Properties { get; set; }

	[JsonProperty("stockmarket")]
	public long StockMarket { get; set; }

	[JsonProperty("auctionhouse")]
	public long AuctionHouse { get; set; }

	[JsonProperty("company")]
	public long Company { get; set; }

	[JsonProperty("bookie")]
	public long Bookie { get; set; }

	[JsonProperty("enlistedcars")]
	public long EnlistedCars { get; set; }

	[JsonProperty("loan")]
	public long Loan { get; set; }

	[JsonProperty("unpaidfees")]
	public long UnpaidFees { get; set; }
}

public class Travel {
	[JsonProperty("destination")]
	public string Destination { get; set; } = "N/A";

	[JsonProperty("method")]
	public string Method { get; set; } = "N/A";

	[JsonProperty("timestamp")]
	public int ArrivalTime { get; set; }

	[JsonProperty("departed")]
	public int Departed { get; set; }
	[JsonProperty("time_left")]
	public int TimeLeft { get; set; }
}

public class Cooldown {
	[JsonProperty("drug")]
	public int DrugCooldown { get; set; }

	[JsonProperty("medical")]
	public int MedicalCooldown { get; set; }

	[JsonProperty("booster")]
	public int BoosterCooldown { get; set; }
}

public class CriminalRecord {
	[JsonProperty("vandalism")]
	public int Vandalism { get; set; }

	[JsonProperty("theft")]
	public int Theft { get; set; }

	[JsonProperty("counterfeiting")]
	public int Counterfeiting { get; set; }

	[JsonProperty("fraud")]
	public int Fraud { get; set; }

	[JsonProperty("illicitservices")]
	public int IllicitServices { get; set; }

	[JsonProperty("cybercrime")]
	public int CyberCrime { get; set; }

	[JsonProperty("extortion")]
	public int Extortion { get; set; }

	[JsonProperty("illegalproduction")]
	public int IllegalProduction { get; set; }

	[JsonProperty("total")]
	public int Total { get; set; }
}

public class Bar {
	[JsonProperty("current")]
	public int Current { get; set; }

	[JsonProperty("maximum")]
	public int Maximum { get; set; }

	[JsonProperty("increment")]
	public int Increment { get; set; }

	[JsonProperty("interval")]
	public int Interval { get; set; }

	[JsonProperty("ticktime")]
	public int TickTime { get; set; }

	[JsonProperty("fulltime")]
	public int FullTime { get; set; }
}

public class WorkStats {
	[JsonProperty("manual_labor")]
	public int MAN { get; set; }

	[JsonProperty("intelligence")]
	public int INT { get; set; }

	[JsonProperty("endurance")]
	public int END { get; set; }
}