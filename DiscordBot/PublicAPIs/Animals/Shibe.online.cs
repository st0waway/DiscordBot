using DiscordBot.Helper;

namespace DiscordBot.PublicAPIs.Animals
{
	internal class Shibe
	{
		public static string GetShibeImage()
		{
			var url = "https://shibe.online/api/shibes";
			var response = Utils.GetWebResponse(url);
			response = response.Substring(2, response.Length - 4);
			return response;
		}
	}
}
