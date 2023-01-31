using DiscordBot.Helper;
using DiscordBot.Models.Entertainment.ChuckNorrisIO;
using Newtonsoft.Json;

namespace DiscordBot.PublicAPIs.Entertainment
{
    internal class ChuckNorris
    {
	    public static string ChuckJoke()
	    {
		    var url = "https://api.chucknorris.io/jokes/random";
		    var response = Utils.GetWebResponse(url);
		    var deserializedResponse = JsonConvert.DeserializeObject<ChuckJokeResponse>(response);
		    return deserializedResponse.Value;
	    }
	}
}
