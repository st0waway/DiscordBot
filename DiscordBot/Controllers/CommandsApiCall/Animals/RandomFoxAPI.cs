using DiscordBot.Controllers.Utils;
using DiscordBot.Models;
using DiscordBot.Models.Animals.RandomFoxAPI;
using Newtonsoft.Json;

namespace DiscordBot.Controllers.CommandsApiCall.Animals
{
    internal class RandomFoxApi : IWebApiCaller
    {
        public string GetApiResponse()
        {
            const string url = "https://randomfox.ca/floof/";
            var response = WebRequestHandler.GetWebResponse(url);
            var deserializedResponse = JsonConvert.DeserializeObject<FoxImageResponse>(response);
            if (deserializedResponse?.Image != null)
            {
                return deserializedResponse.Image;
            }

            Logger.WriteLog("The deserialized response was null");
            throw new NullReferenceException("The deserialized response was null");
        }
    }
}
