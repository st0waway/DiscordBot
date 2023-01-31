using DiscordBot.Models.Personality.Affirmations;
using DiscordBot.Utils;
using Newtonsoft.Json;

namespace DiscordBot.PublicAPIs.Personality
{
    public class AffirmationsAPI
	{
		public static string GetAffirmation()
		{
			var url = "https://www.affirmations.dev/";
			var response = WebRequestHandler.GetWebResponse(url);
			var deserializedResponse = JsonConvert.DeserializeObject<AffirmationResponse>(response);
			return deserializedResponse.Affirmation;
		}
	}
}
