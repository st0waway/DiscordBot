using DiscordBot.Controllers.Utils;
using DiscordBot.Models.Personality.AdviceSlipAPI;
using Newtonsoft.Json;

namespace DiscordBot.Controllers.CommandsApiCall.Personality
{
    internal class AdviceSlipApi
    {
        public static string GetApiResponse()
        {
            const string url = "https://api.adviceslip.com/advice";
            var response = WebRequestHandler.GetWebResponse(url);
            var deserializedResponse = JsonConvert.DeserializeObject<AdviceSlipResponse>(response);
            if (deserializedResponse?.Slip?.Advice != null)
            {
                return deserializedResponse.Slip.Advice;
            }

            Logger.WriteLog("The deserialized response was null");
            throw new NullReferenceException("The deserialized response was null");
        }
    }
}
