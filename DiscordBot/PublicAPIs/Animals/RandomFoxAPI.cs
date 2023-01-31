using DiscordBot.Models.Animals.RandomFoxAPI;
using DiscordBot.Utils;
using Newtonsoft.Json;

namespace DiscordBot.PublicAPIs.Animals
{
    internal class RandomFoxAPI
	{
		public static string GetRandomFox()
		{
			var url = "https://randomfox.ca/floof/";
			var response = WebRequestHandler.GetWebResponse(url);
			var deserializedResponse = JsonConvert.DeserializeObject<FoxImageResponse>(response);
			return deserializedResponse.Image;
		}
	}
}
