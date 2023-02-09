using DiscordBot.Controllers.Utils;
using DiscordBot.Models;
using DiscordBot.Models.Personality.Affirmations;
using Newtonsoft.Json;

namespace DiscordBot.Controllers.CommandsApiCall.Personality
{
    public class AffirmationsApi : IWebApiCaller
    {
        public string GetApiResponse()
        {
            const string url = "https://www.affirmations.dev/";
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
