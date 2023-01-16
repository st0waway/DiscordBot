using DiscordBot.Helper;
using DiscordBot.Models.Personality.AdviceSlipAPI;
using Newtonsoft.Json;

namespace DiscordBot.PublicAPIs.Personality
{
    internal class AdviceSlipAPI
	{
		public static string Advice()
		{
			var url = "https://api.adviceslip.com/advice";
			var response = Utils.GetWebResponse(url);
			var deserializedResponse = JsonConvert.DeserializeObject<AdviceSlipResponse>(response);
			return deserializedResponse.Slip.Advice;
		}
	}
}
