using DiscordBot.Helper;
using DiscordBot.Models.Animals.MeowFacts;
using Newtonsoft.Json;

namespace DiscordBot.PublicAPIs.Animals
{
	internal class MeowFacts
	{
		public static string MeowFact()
		{
			var url = "https://meowfacts.herokuapp.com/";
			var response = Utils.GetWebResponse(url);
			var deserializedResponse = JsonConvert.DeserializeObject<MeowFactResponse>(response);
			return deserializedResponse.data[0];
		}
	}
}
