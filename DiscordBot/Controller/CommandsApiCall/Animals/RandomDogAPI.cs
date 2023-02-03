using DiscordBot.Controller.Utils;
using DiscordBot.Model.Animals.RandomDogAPI;
using Newtonsoft.Json;

namespace DiscordBot.Controller.CommandsApiCall.Animals
{
    internal class RandomDogApi
    {
        public static string GetRandomDog()
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
