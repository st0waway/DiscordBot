using DiscordBot.Models.Entertainment.ChuckNorrisIO;
using DiscordBot.Utils;
using Newtonsoft.Json;

namespace DiscordBot.PublicAPIs.Entertainment
{
    internal class ChuckNorris
    {
	    public static string GetChuckJoke()
	    {
		    var url = "https://api.chucknorris.io/jokes/random";
		    var response = WebRequestHandler.GetWebResponse(url);
		    var deserializedResponse = JsonConvert.DeserializeObject<ChuckJokeResponse>(response);
		    return deserializedResponse.Value;
	    }
	}
}
