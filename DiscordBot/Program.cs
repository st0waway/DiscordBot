using System.Configuration;

using Discord;
using Discord.WebSocket;

using DiscordBot.Helper;
using DiscordBot.PublicAPIs.Animals;
using DiscordBot.PublicAPIs.Anime;
using DiscordBot.PublicAPIs.Personality;

namespace DiscordBot
{
	internal class Program
	{
		static void Main(string[] args) => new Program().MainAsync().GetAwaiter().GetResult();

		private async Task MainAsync()
		{
			var config = new DiscordSocketConfig()
			{
				GatewayIntents = GatewayIntents.AllUnprivileged | GatewayIntents.MessageContent
			};
			DiscordSocketClient client = new DiscordSocketClient(config);
			client.MessageReceived += CommandsHandler;
			client.Log += Log;

			var token = ConfigurationManager.AppSettings["discordToken"];
			await client.LoginAsync(TokenType.Bot, token);
			await client.StartAsync();

			Console.ReadLine();
		}

		private Task Log(LogMessage msg)
		{
			Console.WriteLine(msg.ToString());
			return Task.CompletedTask;
		}

		private Task CommandsHandler(SocketMessage msg)
		{
			Console.WriteLine(msg.Timestamp);
			Console.WriteLine(msg.Author);
			Console.WriteLine(msg.Content);

			if (!msg.Author.IsBot)
			{
				if (msg.Content.Contains("!kg"))
				{
					Int32.TryParse(msg.Content.Split(' ')[1], out var kg);
					var pounds = Utils.KgToPoundsConversion(kg);
					msg.Channel.SendMessageAsync($"{pounds} pounds");
				}

				if (msg.Content.Contains("!pounds"))
				{
					Int32.TryParse(msg.Content.Split(' ')[1], out var pounds);
					var kg = Utils.PoundsToKgConversion(pounds);
					msg.Channel.SendMessageAsync($"{kg} kg");
				}

				switch (msg.Content)
				{
					case "!commands":
						{
							var text = Utils.GetCommands();
							msg.Channel.SendMessageAsync(text);
							break;
						}

					//animals
					case "!cat":
						{
							var text = Cataas.GetCatImage();
							msg.Channel.SendMessageAsync(text);
							break;
						}

					case "!dogfact":
						{
							var text = DogAPI.DogFact();
							msg.Channel.SendMessageAsync(text);
							break;
						}

					case "!duck":
						{
							var text = RandomDuckAPIv2.RandomDuck();
							msg.Channel.SendMessageAsync(text);
							break;
						}

					case "!fox":
						{
							var text = RandomFoxAPI.RandomFox();
							msg.Channel.SendMessageAsync(text);
							break;
						}

					case "!meowfact":
					{
						var text = MeowFacts.MeowFact();
						msg.Channel.SendMessageAsync(text);
						break;
					}

					//anime
					case "!8ball":
					{
						var text = CatboyAPI.EightBall();
						msg.Channel.SendMessageAsync(text);
						break;
					}

					case "!baka":
						{
							var text = CatboyAPI.Baka();
							msg.Channel.SendMessageAsync(text);
							break;
						}

					case "!dice":
						{
							var text = CatboyAPI.Dice();
							msg.Channel.SendMessageAsync(text);
							break;
						}

					//personality
					case "!advice":
					{
						var text = AdviceSlipAPI.Advice();
						msg.Channel.SendMessageAsync(text);
						break;

					}

					case "!affirmation":
						{
							var text = AffirmationsAPI.Affirmation();
							msg.Channel.SendMessageAsync(text);
							break;
						}


				}
			}

			return Task.CompletedTask;
		}
	}
}
