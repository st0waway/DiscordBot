using DiscordBot.Controllers.Utils;
using DiscordBot.Models;
using DiscordBot.Models.Animals.MeowFacts;
using Newtonsoft.Json;

namespace DiscordBot.Controllers.CommandsApiCall.Animals
{
    internal class MeowFacts : IWebApiCaller
    {
        public string GetApiResponse()
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
