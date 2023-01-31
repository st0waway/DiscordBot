using DiscordBot.Helper;
using DiscordBot.Models.Animals.RandomDogAPI;
using Newtonsoft.Json;

namespace DiscordBot.PublicAPIs.Animals
{
	internal class RandomDogAPI
	{
		public static string GetRandomDog()
		{
			var url = "https://random.dog/woof.json";
			var response = Utils.GetWebResponse(url);
			var deserializedResponse = JsonConvert.DeserializeObject<RandomDogResponse>(response);
			return deserializedResponse.Url;
		}
	}
}
