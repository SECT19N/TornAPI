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