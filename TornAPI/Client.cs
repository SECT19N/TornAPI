using Newtonsoft.Json;
using TornAPI.Enums;
using TornAPI.UserData;
using TornAPI.Utils;

namespace TornAPI;

public class Client {
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

	public async Task<User> GetUser(UserSelections selections) {
		User? user = null;

		string selectionsString = selections.ToCommaSeparatedString();

		try {
			using (HttpClient httpClient = new()) {
				HttpResponseMessage response = await httpClient.GetAsync($@"https://api.torn.com/user/?selections={selectionsString}&key={ApiKey}");

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
			await Console.Out.WriteLineAsync($"Http Request Exception: {ex.Message}");
		} catch (JsonException ex) {

		} catch (Exception ex) {
			await Console.Out.WriteLineAsync($"Exception: {ex.Message}");
		}

		return user;
	}
}

public static class UserSelectionsExtensions {
	public static string ToCommaSeparatedString(this UserSelections selections) {
		return string.Join(",", Enum.GetValues(typeof(UserSelections))
									.Cast<UserSelections>()
									.Where(selection => selections.HasFlag(selection))
									.Select(selection => selection.ToString()));
	}
}
