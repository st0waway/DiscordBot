using DiscordBot.Controllers.Utils;
using DiscordBot.Models.Entertainment.RandomUselessFacts;
using Newtonsoft.Json;

namespace DiscordBot.Controllers.CommandsApiCall.Entertainment
{
	internal class RandomUselessFacts
	{
		public static string GetApiResponse()
		{
			const string url = "https://uselessfacts.jsph.pl/random.json?language=en";
			var response = WebRequestHandler.GetWebResponse(url);
			var deserializedResponse = JsonConvert.DeserializeObject<RandomUselessFactResponse>(response);
			if (deserializedResponse?.Text != null)
			{
				return deserializedResponse.Text;
			}

			Logger.WriteLog("The deserialized response was null");
			throw new NullReferenceException("The deserialized response was null");
		}
	}
}
