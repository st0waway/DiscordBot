using System.Configuration;

namespace DiscordBot.Commands
{
	internal class Commands
	{
		public static string GetCommands()
		{
			var reader = new StreamReader(ConfigurationManager.AppSettings["commandsPath"]!);
			var helpText = reader.ReadToEnd();
			return helpText;
		}
	}
}
