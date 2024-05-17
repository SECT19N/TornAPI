using System.Net;
using TornAPI;
using TornAPI.UserData;

namespace TornAPIDemo;

internal class Program {
	static async Task Main(string[] args) {
		//HttpClient client = new();
		Client client;

		try {
			//string response = client.GetStringAsync(@"https://api.torn.com/user/?selections=cars&key=fHNAatgZ3hm8iOIb").Result;
			Console.Write("Please enter API Key: ");
			string key = Console.ReadLine().Trim();

			client = new Client(key);

			User user = await client.GetUser(new string[] { "" }) ?? new User();

			Console.WriteLine(user.SignUp);

			//User user = JsonConvert.DeserializeObject<User>(response);

			//string[] arr = new string[] {
			//	"HI",
			//	"HI",
			//	"HI",
			//	"HI",
			//	"HI"
			//};

			//Console.WriteLine(string.Join(",", arr));

			//Console.ForegroundColor = ConsoleColor.Green;

			//Console.WriteLine("$" + user.Networth?.Total.ToString("N0"));
			//Console.WriteLine("$" + user.Networth?.Wallet.ToString("N0"));
			//Console.WriteLine("$" + user.Networth?.Bank.ToString("N0"));
			//Console.WriteLine("$" + user.Networth?.Cayman.ToString("N0"));
			//Console.WriteLine("$" + user.Networth?.Points.ToString("N0"));

			//Console.ForegroundColor = ConsoleColor.Red;

			//Console.WriteLine("$" + user.Networth?.UnpaidFees.ToString("N0"));

			//Console.ForegroundColor = ConsoleColor.White;

			//Console.WriteLine(user.Crimes.Fraud.ToString());
			//Console.WriteLine(user.Crimes.Theft.ToString("N0"));
			//Console.WriteLine(user.Crimes.Counterfeiting);
			//Console.WriteLine(user.Crimes.CyberCrime);

			//Console.WriteLine(DateTimeOffset.FromUnixTimeSeconds(user.CurrentTime));

			//Console.WriteLine(user.Strength.ToString("N0"));
			//Console.WriteLine(user.Speed.ToString("N0"));
			//Console.WriteLine(user.Dexterity.ToString("N0"));
			//Console.WriteLine(user.Defense.ToString("N0"));

			//Console.WriteLine(user.StrengthModifier + "%");
			//Console.WriteLine(user.SpeedModifier + "%");
			//Console.WriteLine(user.DexterityModifier + "%");
			//Console.WriteLine(user.DefenseModifier + "%");

			//Console.WriteLine(TimeSpan.FromSeconds(user.Cooldowns.DrugCooldown));
			//Console.WriteLine(TimeSpan.FromSeconds(user.Cooldowns.MedicalCooldown));
			//Console.WriteLine(TimeSpan.FromSeconds(user.Cooldowns.BoosterCooldown));

			//Console.WriteLine(user.Travel.Destination);
			//Console.WriteLine(user.Travel.Method);
			//Console.WriteLine(DateTimeOffset.FromUnixTimeSeconds(user.Travel.ArrivalTime));
			//Console.WriteLine(DateTimeOffset.FromUnixTimeSeconds(user.Travel.Departed));
			//Console.WriteLine(TimeSpan.FromSeconds(user.Travel.TimeLeft));

			//Console.WriteLine(DateTimeOffset.FromUnixTimeSeconds(user.ServerTime));
			//Console.WriteLine("Life: (max) " + user.Life.Maximum);
			//Console.WriteLine("Life: (time to full) " + TimeSpan.FromSeconds(user.Life.FullTime));
			//Console.WriteLine("Life: (next time) " + TimeSpan.FromSeconds(user.Life.TickTime));
			//Console.WriteLine("Life: (increment size) " + user.Life.Increment);
			//Console.WriteLine("Life: (current) " + user.Life.Current);
			//Console.WriteLine("Life: (interval) " + TimeSpan.FromSeconds(user.Life.Interval));
		} catch (HttpRequestException ex) {
			Console.WriteLine($"Http Request Exception: {ex.Message}");
		} catch (WebException ex) {
			Console.WriteLine($"Web Exception: {ex.Message}");
		} catch (Exception ex) {
			Console.WriteLine($"Exception: {ex.Message}");
		}
	}
}