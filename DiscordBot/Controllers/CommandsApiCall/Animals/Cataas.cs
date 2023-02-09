using DiscordBot.Controllers.Utils;
using DiscordBot.Models.Animals.Cataas;
using Newtonsoft.Json;

namespace DiscordBot.Controllers.CommandsApiCall.Animals
{
    internal class Cataas
    {
        public static string GetApiResponse()
        {
            const string url = "https://cataas.com/cat?json=true";
            var response = WebRequestHandler.GetWebResponse(url);
            var deserializedResponse = JsonConvert.DeserializeObject<CataasImageResponse>(response);
            if (deserializedResponse != null)
            {
                return "https://cataas.com" + deserializedResponse.Url;
            }

            Logger.WriteLog("The deserialized response was null");
            throw new NullReferenceException("The deserialized response was null");
        }
    }
}
