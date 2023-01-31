using DiscordBot.Models.Animals.MeowFacts;
using DiscordBot.Utils;
using Newtonsoft.Json;

namespace DiscordBot.PublicAPIs.Animals
{
    internal class MeowFacts
	{
		public static string GetMeowFact()
		{
			var url = "https://meowfacts.herokuapp.com/";
			var response = WebRequestHandler.GetWebResponse(url);
			var deserializedResponse = JsonConvert.DeserializeObject<MeowFactResponse>(response);
			return deserializedResponse.data[0];
		}
	}
}
