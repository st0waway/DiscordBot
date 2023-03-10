using DiscordBot.Controllers.Utils;
using DiscordBot.Models;
using DiscordBot.Models.Animals.RandomDogAPI;
using Newtonsoft.Json;

namespace DiscordBot.Controllers.CommandsApiCall.Animals
{
    internal class RandomDogApi : IWebApiCaller
    {
        public string GetApiResponse()
        {
            const string url = "https://random.dog/woof.json";
            var response = WebRequestHandler.GetWebResponse(url);
            var deserializedResponse = JsonConvert.DeserializeObject<RandomDogResponse>(response);
            if (deserializedResponse?.Url != null)
            {
                return deserializedResponse.Url;
            }

            Logger.WriteLog("The deserialized response was null");
            throw new NullReferenceException("The deserialized response was null");
        }
    }
}
