using DiscordBot.Models.Personality.Affirmations;
using DiscordBot.Utils;
using Newtonsoft.Json;

namespace DiscordBot.PublicAPIs.Personality
{
    public class AffirmationsApi
	{
		public static string GetAffirmation()
		{
			var url = "https://www.affirmations.dev/";
			var response = WebRequestHandler.GetWebResponse(url);
			var deserializedResponse = JsonConvert.DeserializeObject<AffirmationResponse>(response);
			if (deserializedResponse?.Affirmation != null)
			{
				return deserializedResponse.Affirmation;
			}

			Logger.WriteLog("The deserialized response was null");
			throw new NullReferenceException("The deserialized response was null");
		}
	}
}
