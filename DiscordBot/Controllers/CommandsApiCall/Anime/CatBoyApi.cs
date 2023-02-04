using DiscordBot.Controllers.Utils;
using DiscordBot.Models.Anime.CatboyAPI;
using Newtonsoft.Json;

namespace DiscordBot.Controllers.CommandsApiCall.Anime;

public class CatBoyApi
{
    public static string GetBakaGif()
    {
        const string url = "https://api.catboys.com/baka";
        var response = WebRequestHandler.GetWebResponse(url);
        var deserializedResponse = JsonConvert.DeserializeObject<BakaGifReposnse>(response);
        if (deserializedResponse?.Url != null)
        {
            return deserializedResponse.Url;
        }

        Logger.WriteLog("The deserialized response was null");
        throw new NullReferenceException("The deserialized response was null");
    }

    public static string GetDice()
    {
        const string url = "https://api.catboys.com/dice";
        var response = WebRequestHandler.GetWebResponse(url);
        var deserializedResponse = JsonConvert.DeserializeObject<DiceImageResponse>(response);
        if (deserializedResponse?.Url != null)
        {
            return deserializedResponse.Url;
        }

        Logger.WriteLog("The deserialized response was null");
        throw new NullReferenceException("The deserialized response was null");
    }

    public static string GetEightBallImage()
    {
        const string url = "https://api.catboys.com/8ball";
        var response = WebRequestHandler.GetWebResponse(url);
        var deserializedResponse = JsonConvert.DeserializeObject<DiceImageResponse>(response);
        if (deserializedResponse?.Url != null)
        {
            return deserializedResponse.Url;
        }

        Logger.WriteLog("The deserialized response was null");
        throw new NullReferenceException("The deserialized response was null");
    }
}