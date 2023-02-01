using DiscordBot.Models.Entertainment.ChuckNorrisIO;
using DiscordBot.Utils;

using Newtonsoft.Json;

namespace DiscordBot.PublicAPIs.Entertainment
{
	internal class ChuckNorris
	{
		public static string GetChuckJoke()
		{
			const string url = "https://api.chucknorris.io/jokes/random";
			var response = WebRequestHandler.GetWebResponse(url);
			var deserializedResponse = JsonConvert.DeserializeObject<ChuckJokeResponse>(response);
			if (deserializedResponse?.Value != null)
			{
				return deserializedResponse.Value;
			}

			Logger.WriteLog("The deserialized response was null");
			throw new NullReferenceException("The deserialized response was null");
		}
	}
}
