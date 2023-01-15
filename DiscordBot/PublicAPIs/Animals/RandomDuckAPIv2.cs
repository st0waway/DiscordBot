using DiscordBot.Helper;
using DiscordBot.Models.Animals.RandomDuckAPI;
using Newtonsoft.Json;

namespace DiscordBot.PublicAPIs.Animals
{
    internal class RandomDuckAPIv2
	{
		public static string RandomDuck()
		{
			var url = "https://random-d.uk/api/v2/random";
			var response = Utils.GetWebResponse(url);
			var deserializedResponse = JsonConvert.DeserializeObject<RandomDuck>(response);
			return deserializedResponse.Url;
		}
	}
}
