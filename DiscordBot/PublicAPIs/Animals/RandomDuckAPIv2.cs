using DiscordBot.Models.Animals.RandomDuckAPI;
using DiscordBot.Utils;
using Newtonsoft.Json;

namespace DiscordBot.PublicAPIs.Animals
{
    internal class RandomDuckAPIv2
	{
		public static string GetRandomDuck()
		{
			var url = "https://random-d.uk/api/v2/random";
			var response = WebRequestHandler.GetWebResponse(url);
			var deserializedResponse = JsonConvert.DeserializeObject<DuckImageResponse>(response);
			return deserializedResponse.Url;
		}
	}
}
