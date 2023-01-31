using DiscordBot.Models.Animals.Cataas;
using DiscordBot.Utils;
using Newtonsoft.Json;

namespace DiscordBot.PublicAPIs.Animals
{
    internal class Cataas
	{
		public static string GetCatImage()
		{
			var url = "https://cataas.com/cat?json=true";
			var response = WebRequestHandler.GetWebResponse(url);
			var deserializedResponse = JsonConvert.DeserializeObject<CataasImageResponse>(response);
			return "https://cataas.com" + deserializedResponse.Url;
		}
	}
}
