using DiscordBot.Helper;
using DiscordBot.Models.Animals.RandomFoxAPI;
using Newtonsoft.Json;

namespace DiscordBot.PublicAPIs.Animals
{
    internal class RandomFoxAPI
	{
		public static string RandomFox()
		{
			var url = "https://randomfox.ca/floof/";
			var response = Utils.GetWebResponse(url);
			var deserializedResponse = JsonConvert.DeserializeObject<FoxImageResponse>(response);
			return deserializedResponse.Image;
		}
	}
}
