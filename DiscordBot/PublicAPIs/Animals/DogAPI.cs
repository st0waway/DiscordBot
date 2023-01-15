using DiscordBot.Helper;
using DiscordBot.Models.Animals.DogAPI;
using Newtonsoft.Json;

namespace DiscordBot.PublicAPIs.Animals
{
	internal class DogAPI
	{
		public static string DogFact()
		{
			var url = "https://dog-api.kinduff.com/api/facts";
			var response = Utils.GetWebResponse(url);
			var deserializedResponse = JsonConvert.DeserializeObject<DogFact>(response);
			return deserializedResponse.Facts[0];
		}
	}
}
