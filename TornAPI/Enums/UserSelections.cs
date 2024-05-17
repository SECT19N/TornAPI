namespace TornAPI.Enums;

/// <summary>
/// An enumerator list to represent select able fields from Torn API.
/// </summary>
/// <remarks>
///	Not all fields are implenented in this API.
/// </remarks>
[Flags]
public enum UserSelections {
	None,
	Ammo,
	Attacks,
	AttacksFull,
	Bars,
	Basic,
	BattleStats,
	Bazaar,
	Cooldowns,
	Crimes,
	Discord,
	Display,
	Education,
	Equipment,
	Events,
	Gym,
	HoF,
	Honors,
	Icons,
	Inventory,
	JobPoints,
	Log,
	Medals,
	Merits,
	Messages,
	Missions,
	Money,
	Networth,
	NewEvents,
	NewMessages,
	Notifications,
	Perks,
	PersonalStats,
	profile,
	Properties,
	Refills,
	Reports,
	Revives,
	Skills,
	Stocks,
	Timestamp,
	Travel,
	WeaponXP,
	WorkStats
}