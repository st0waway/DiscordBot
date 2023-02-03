using System.Configuration;

namespace DiscordBot.Controller.CommandsLocal
{
    internal class CommandsList
    {
        public static string GetCommandsList()
        {
            var reader = new StreamReader(ConfigurationManager.AppSettings["commandsPath"]!);
            var helpText = reader.ReadToEnd();
            return helpText;
        }
    }
}
