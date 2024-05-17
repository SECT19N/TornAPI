using Newtonsoft.Json;
using TornAPI.UserData;

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

	public async Task<User> GetUser(string[] selections) {
		User? user = null;

		try {
			using (HttpClient httpClient = new()) {
				HttpResponseMessage response = await httpClient.GetAsync($@"https://api.torn.com/user/?selections={string.Join(",", selections)}&key=${ApiKey}");

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

public class ErrorWrapper {
    [JsonProperty("error")]
    public ApiError Error { get; set; }
}

public class ApiError {
	[JsonProperty("code")]
    public int Code { get; set; }

	[JsonProperty("error")]
	public string Message { get; set; }
}