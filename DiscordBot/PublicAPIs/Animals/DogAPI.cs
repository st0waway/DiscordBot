using DiscordBot.Models.Animals.DogAPI;
using DiscordBot.Utils;
using Newtonsoft.Json;

namespace DiscordBot.PublicAPIs.Animals
{
    internal class DogAPI
	{
		public static string GetDogFact()
		{
			var url = "https://dog-api.kinduff.com/api/facts";
			var response = WebRequestHandler.GetWebResponse(url);
			var deserializedResponse = JsonConvert.DeserializeObject<DogFactResponse>(response);
			return deserializedResponse.Facts[0];
		}
	}
}
