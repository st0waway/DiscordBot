using DiscordBot.Helper;
using DiscordBot.Models.Personality.Affirmations;
using Newtonsoft.Json;

namespace DiscordBot.PublicAPIs.Personality
{
    public class AffirmationsAPI
	{
		public static string Affirmation()
		{
			var url = "https://www.affirmations.dev/";
			var response = Utils.GetWebResponse(url);
			var deserializedResponse = JsonConvert.DeserializeObject<AffirmationResponse>(response);
			return deserializedResponse.Affirmation;
		}
	}
}
