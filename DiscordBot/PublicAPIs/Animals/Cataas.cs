using DiscordBot.Models.Animals.Cataas;
using DiscordBot.Utils;
using Newtonsoft.Json;

namespace DiscordBot.PublicAPIs.Animals
{
    internal class Cataas
	{
		public static string GetCatImage()
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
