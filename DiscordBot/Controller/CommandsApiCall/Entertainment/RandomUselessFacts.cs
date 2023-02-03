using DiscordBot.Controller.Utils;
using DiscordBot.Model.Entertainment.ChuckNorrisIO;
using DiscordBot.Model.Entertainment.RandomUselessFacts;
using Newtonsoft.Json;

namespace DiscordBot.Controller.CommandsApiCall.Entertainment
{
	internal class RandomUselessFacts
	{
		public static string GetRandomUselessFact()
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
