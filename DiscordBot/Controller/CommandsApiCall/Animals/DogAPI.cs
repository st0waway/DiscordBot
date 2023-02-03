using DiscordBot.Controller.Utils;
using DiscordBot.Model.Animals.DogAPI;
using Newtonsoft.Json;

namespace DiscordBot.Controller.CommandsApiCall.Animals
{
    internal class DogApi
    {
        public static string GetDogFact()
        {
            const string url = "https://dog-api.kinduff.com/api/facts";
            var response = WebRequestHandler.GetWebResponse(url);
            var deserializedResponse = JsonConvert.DeserializeObject<DogFactResponse>(response);
            if (deserializedResponse?.Facts != null)
            {
                return deserializedResponse.Facts[0];
            }

            Logger.WriteLog("The deserialized response was null");
            throw new NullReferenceException("The deserialized response was null");
        }
    }
}
