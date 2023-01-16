using DiscordBot.Helper;
using DiscordBot.Models.Animals.Quokka.pics;
using Newtonsoft.Json;

namespace DiscordBot.PublicAPIs.Animals
{
	internal class Quokkapics
	{
		public static string GetQuokkaPic()
		{
			var url = "https://quokka.pics/api/";
			var response = Utils.GetWebResponse(url);
			var deserializedResponse = JsonConvert.DeserializeObject<QuokkaImageResponse>(response);
			return deserializedResponse.Image;
		}
	}
}
