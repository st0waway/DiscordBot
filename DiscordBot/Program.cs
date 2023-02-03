using System.Configuration;
using Discord;
using Discord.WebSocket;
using DiscordBot.View;

namespace DiscordBot
{
    internal class Program
	{
		private static void Main() => MainAsync().GetAwaiter().GetResult();

		private static async Task MainAsync()
		{
			var config = new DiscordSocketConfig()
			{
				GatewayIntents = GatewayIntents.AllUnprivileged | GatewayIntents.MessageContent
			};
			var client = new DiscordSocketClient(config);
			client.MessageReceived += CommandsHandler.HandleCommands;
			client.MessageReceived += CommandsHandler.HandleArgumentedCommands;
			client.Log += Log;

			var token = ConfigurationManager.AppSettings["discordToken"];
			await client.LoginAsync(TokenType.Bot, token);
			await client.StartAsync();

			Console.ReadLine();
		}

		private static Task Log(LogMessage msg)
		{
			Console.WriteLine(msg.ToString());
			return Task.CompletedTask;
		}
	}
}
