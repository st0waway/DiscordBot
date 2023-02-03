using DiscordBot.Controller.Utils;
using DiscordBot.Model.Animals.RandomFoxAPI;
using Newtonsoft.Json;

namespace DiscordBot.Controller.CommandsApiCall.Animals
{
    internal class RandomFoxApi
    {
        public static string GetRandomFox()
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
