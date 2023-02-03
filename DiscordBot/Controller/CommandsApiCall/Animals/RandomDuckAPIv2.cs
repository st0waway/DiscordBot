using DiscordBot.Controller.Utils;
using DiscordBot.Model.Animals.RandomDuckAPI;
using Newtonsoft.Json;

namespace DiscordBot.Controller.CommandsApiCall.Animals
{
    internal class RandomDuckApIv2
    {
        public static string GetRandomDuck()
        {
            const string url = "https://random-d.uk/api/v2/random";
            var response = WebRequestHandler.GetWebResponse(url);
            var deserializedResponse = JsonConvert.DeserializeObject<DuckImageResponse>(response);
            if (deserializedResponse?.Url != null)
            {
                return deserializedResponse.Url;
            }

            Logger.WriteLog("The deserialized response was null");
            throw new NullReferenceException("The deserialized response was null");
        }
    }
}
