using DiscordBot.Controllers.Utils;
using DiscordBot.Models;
using Newtonsoft.Json;

namespace DiscordBot.Controllers.CommandsApiCall.Animals
{
    internal class Shibe : IWebApiCaller
    {
        public string GetApiResponse()
        {
            const string url = "https://shibe.online/api/shibes";
            var response = WebRequestHandler.GetWebResponse(url);
            var deserializedResponse = JsonConvert.DeserializeObject<string[]>(response);
            if (deserializedResponse != null)
            {
                return deserializedResponse[0];
            }

            Logger.WriteLog("The deserialized response was null");
            throw new NullReferenceException("The deserialized response was null");
        }
    }
}
