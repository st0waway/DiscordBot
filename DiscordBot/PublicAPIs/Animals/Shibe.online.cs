using DiscordBot.Utils;
using Newtonsoft.Json;

namespace DiscordBot.PublicAPIs.Animals
{
    internal class Shibe
	{
		public static string GetShibeImage()
		{
			var url = "https://shibe.online/api/shibes";
			var response = WebRequestHandler.GetWebResponse(url);
			var deserializedResponse = JsonConvert.DeserializeObject<string[]>(response);
			return deserializedResponse[0];
		}
	}
}
