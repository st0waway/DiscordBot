using System.Configuration;
using System.Net;

namespace DiscordBot.Helper
{
	public class Utils
	{
		public static string GetWebResponse(string url)
		{
			var request = (HttpWebRequest)WebRequest.Create(url);
			var httpWebResponse = (HttpWebResponse)request.GetResponse();
			using StreamReader streamReader = new StreamReader(httpWebResponse.GetResponseStream());
			return streamReader.ReadToEnd();
		}

		public static string GetCommands()
		{
			var reader = new StreamReader(ConfigurationManager.AppSettings["commandsPath"]!);
			var helpText = reader.ReadToEnd();
			return helpText;
		}
	}
}
