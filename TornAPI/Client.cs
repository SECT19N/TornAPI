using Newtonsoft.Json;
using TornAPI.Enums;
using TornAPI.MarketData;
using TornAPI.UserData;
using TornAPI.Utils;

namespace TornAPI;

public class Client {
	readonly string ApiUrl = @"https://api.torn.com/";

	public string ApiKey { get; set; }
	public int CallsPerMinute { get; set; } = 100;
	public DateTime LastCall { get; set; } = DateTime.Now;

	public Client() {

	}

	public Client(string key) {
		ApiKey = key;
	}

	public Client(string key, int calls) {
		ApiKey = key;
		CallsPerMinute = calls;
	}

	/// <summary>
	/// Gets data from Torn API and stores them in an object.
	/// </summary>
	/// <param name="selections">Selections of user fields to be requested from Torn API.</param>
	/// <returns>An object instance of User.</returns>
	public async Task<User> GetUser(UserSelections selections) {
		User? user = null;

		string selectionsString = selections.ToCommaSeparatedString();

		try {
			using (HttpClient httpClient = new()) {
				HttpResponseMessage response = await httpClient.GetAsync($@"{ApiUrl}user/?selections={selectionsString}&key={ApiKey}");

				string jsonResponse = await response.Content.ReadAsStringAsync();

				if (response.IsSuccessStatusCode) {
					if (jsonResponse.Contains("\"error\"")) {
						ErrorWrapper errorWrapper = JsonConvert.DeserializeObject<ErrorWrapper>(jsonResponse);
						throw new Exception($"{errorWrapper.Error.Code}: {errorWrapper.Error.Message}");
					} else {
						user = JsonConvert.DeserializeObject<User>(jsonResponse);
					}
				} else {
					ErrorWrapper errorWrapper = JsonConvert.DeserializeObject<ErrorWrapper>(jsonResponse);
					throw new Exception($"{errorWrapper.Error.Code}: {errorWrapper.Error.Message}");
				}
			}
		} catch (HttpRequestException ex) {
			throw new HttpRequestException(ex.Message, ex);
		} catch (JsonException ex) {
			throw new JsonException(ex.Message, ex);
		} catch (Exception ex) {
			throw new Exception(ex.Message, ex);
		}

		return user;
	}

	/// <summary>
	/// Gets data from Torn API and stores them in an object.
	/// </summary>
	/// <param name="selections">Selections of Market fields to be requested from Torn API.</param>
	/// <param name="itemId">ID of the requested Item.</param>
	/// <returns>Instance of Market.</returns>
	public async Task<Market> GetMarket(MarketSelections selections, int itemId) {
		Market? market = null;

		string selectionsString = selections.ToCommaSeparatedString();

		try {
			using (HttpClient httpClient = new()) {
				HttpResponseMessage response = await httpClient.GetAsync($@"{ApiUrl}market/{itemId}?selections={selectionsString}&key={ApiKey}");

				string jsonResponse = await response.Content.ReadAsStringAsync();

				if (response.IsSuccessStatusCode) {
					if (jsonResponse.Contains("\"error\"")) {
						ErrorWrapper errorWrapper = JsonConvert.DeserializeObject<ErrorWrapper>(jsonResponse);
						throw new Exception($"{errorWrapper.Error.Code}: {errorWrapper.Error.Message}");
					} else {
						market = JsonConvert.DeserializeObject<Market>(jsonResponse);
					}
				} else {
					ErrorWrapper errorWrapper = JsonConvert.DeserializeObject<ErrorWrapper>(jsonResponse);
					throw new Exception($"{errorWrapper.Error.Code}: {errorWrapper.Error.Message}");
				}
			}
		} catch (HttpRequestException ex) {
			throw new HttpRequestException(ex.Message, ex);
		} catch (JsonException ex) {
			throw new JsonException(ex.Message, ex);
		} catch (Exception ex) {
			throw new Exception(ex.Message, ex);
		}

		return market;
	}
}

public static class UserSelectionsExtensions {
	public static string ToCommaSeparatedString(this UserSelections selections) {
		return string.Join(",", Enum.GetValues(typeof(UserSelections))
									.Cast<UserSelections>()
									.Where(selection => selections.HasFlag(selection)));
	}

	public static string ToCommaSeparatedString(this MarketSelections selections) {
		return string.Join(",", Enum.GetValues(typeof(MarketSelections))
									.Cast<MarketSelections>()
									.Where(selection => selections.HasFlag(selection)));
	}
}
