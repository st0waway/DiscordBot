using DiscordBot.Controller.Utils;
using DiscordBot.Model.Personality.AdviceSlipAPI;
using Newtonsoft.Json;

namespace DiscordBot.Controller.CommandsApiCall.Personality
{
    internal class AdviceSlipApi
    {
        public static string GetAdvice()
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
