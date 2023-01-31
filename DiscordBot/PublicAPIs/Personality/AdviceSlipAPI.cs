using DiscordBot.Models.Personality.AdviceSlipAPI;
using DiscordBot.Utils;
using Newtonsoft.Json;

namespace DiscordBot.PublicAPIs.Personality
{
    internal class AdviceSlipAPI
	{
		public static string GetAdvice()
		{
			var url = "https://api.adviceslip.com/advice";
			var response = WebRequestHandler.GetWebResponse(url);
			var deserializedResponse = JsonConvert.DeserializeObject<AdviceSlipResponse>(response);
			return deserializedResponse.Slip.Advice;
		}
	}
}
