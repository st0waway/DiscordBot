using DiscordBot.Models.Animals.MeowFacts;
using DiscordBot.Utils;
using Newtonsoft.Json;

namespace DiscordBot.PublicAPIs.Animals
{
    internal class MeowFacts
	{
		public static string GetMeowFact()
		{
			const string url = "https://meowfacts.herokuapp.com/";
			var response = WebRequestHandler.GetWebResponse(url);
			var deserializedResponse = JsonConvert.DeserializeObject<MeowFactResponse>(response);
			if (deserializedResponse?.data != null)
			{
				return deserializedResponse.data[0];
			}

			Logger.WriteLog("The deserialized response was null");
			throw new NullReferenceException("The deserialized response was null");
		}
	}
}
