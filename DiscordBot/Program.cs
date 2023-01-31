using System.Configuration;

using Discord;
using Discord.WebSocket;

using DiscordBot.Helper;
using DiscordBot.Helper.Conversions;
using DiscordBot.PublicAPIs.Animals;
using DiscordBot.PublicAPIs.Anime;
using DiscordBot.PublicAPIs.Entertainment;
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
			//conversions
			if (!msg.Author.IsBot)
			{
				if (msg.Content.Contains("!kg"))
				{
					Int32.TryParse(msg.Content.Split(' ')[1], out var kg);
					var text = WeightConversions.KgToPoundsConversion(kg);
					msg.Channel.SendMessageAsync(text);
					Logger.WriteLog(msg.Content, text);
				}

				if (msg.Content.Contains("!pounds"))
				{
					Int32.TryParse(msg.Content.Split(' ')[1], out var pounds);
					var text = WeightConversions.PoundsToKgConversion(pounds);
					msg.Channel.SendMessageAsync(text);
					Logger.WriteLog(msg.Content, text);
				}

				if (msg.Content.Contains("!fahrenheit"))
				{
					Int32.TryParse(msg.Content.Split(' ')[1], out var fahrenheit);
					var text = TemperatureConversions.FahrenheitToCelsiusConversion(fahrenheit);
					msg.Channel.SendMessageAsync(text);
					Logger.WriteLog(msg.Content, text);
				}

				if (msg.Content.Contains("!celsius"))
				{
					Int32.TryParse(msg.Content.Split(' ')[1], out var celsius);
					var text = TemperatureConversions.CelsiusToFahrenheitConversion(celsius);
					msg.Channel.SendMessageAsync(text);
					Logger.WriteLog(msg.Content, text);
				}

				if (msg.Content.Contains("!cm"))
				{
					Int32.TryParse(msg.Content.Split(' ')[1], out var cm);
					var text = LengthConversions.CmToInchConversion(cm);
					msg.Channel.SendMessageAsync(text);
					Logger.WriteLog(msg.Content, text);
				}

				if (msg.Content.Contains("!inches"))
				{
					Int32.TryParse(msg.Content.Split(' ')[1], out var inches);
					var text = LengthConversions.InchToCmConversion(inches);
					msg.Channel.SendMessageAsync(text);
					Logger.WriteLog(msg.Content, text);
				}

				if (msg.Content.Contains("!placebear"))
				{
					Int32.TryParse(msg.Content.Split(' ')[1], out var width);
					Int32.TryParse(msg.Content.Split(' ')[2], out var height);
					var text = Helper.PlaceX.PlaceBear(width, height);
					msg.Channel.SendMessageAsync(text);
					Logger.WriteLog(msg.Content, text);
				}

				if (msg.Content.Contains("!placedog"))
				{
					Int32.TryParse(msg.Content.Split(' ')[1], out var width);
					Int32.TryParse(msg.Content.Split(' ')[2], out var height);
					var text = Helper.PlaceX.PlaceDog(width, height);
					msg.Channel.SendMessageAsync(text);
					Logger.WriteLog(msg.Content, text);
				}

				if (msg.Content.Contains("!placekitten"))
				{
					Int32.TryParse(msg.Content.Split(' ')[1], out var width);
					Int32.TryParse(msg.Content.Split(' ')[2], out var height);
					var text = Helper.PlaceX.PlaceKitten(width, height);
					msg.Channel.SendMessageAsync(text);
					Logger.WriteLog(msg.Content, text);
				}

				switch (msg.Content)
				{
					//commands
					case "!commands":
					{
						var text = Commands.GetCommands();
							msg.Channel.SendMessageAsync(text);
							Logger.WriteLog(msg.Content, text);
							break;
						}

					//time
					case "!timestow":
						{
							var text = TimeInfo.TimeStowaway();
							msg.Channel.SendMessageAsync(text);
							Logger.WriteLog(msg.Content, text);
							break;
						}

					case "!timesashimi":
						{
							var text = TimeInfo.TimeSashimi();
							msg.Channel.SendMessageAsync(text);
							Logger.WriteLog(msg.Content, text);
							break;
						}

					case "!timeaniq":
						{
							var text = TimeInfo.TimeAniq();
							msg.Channel.SendMessageAsync(text);
							Logger.WriteLog(msg.Content, text);
							break;
						}

					case "!timewood":
						{
							var text = TimeInfo.TimeWood();
							msg.Channel.SendMessageAsync(text);
							Logger.WriteLog(msg.Content, text);
							break;
						}

					//animals
					case "!cat":
						{
							var text = Cataas.GetCatImage();
							msg.Channel.SendMessageAsync(text);
							Logger.WriteLog(msg.Content, text);
							break;
						}

					case "!dog":
						{
							var text = RandomDogAPI.GetRandomDog();
							msg.Channel.SendMessageAsync(text);
							Logger.WriteLog(msg.Content, text);
							break;
						}

					case "!dogfact":
						{
							var text = DogAPI.GetDogFact();
							msg.Channel.SendMessageAsync(text);
							Logger.WriteLog(msg.Content, text);
							break;
						}

					case "!duck":
						{
							var text = RandomDuckAPIv2.GetRandomDuck();
							msg.Channel.SendMessageAsync(text);
							Logger.WriteLog(msg.Content, text);
							break;
						}

					case "!fox":
						{
							var text = RandomFoxAPI.GetRandomFox();
							msg.Channel.SendMessageAsync(text);
							Logger.WriteLog(msg.Content, text);
							break;
						}

					case "!meowfact":
						{
							var text = MeowFacts.GetMeowFact();
							msg.Channel.SendMessageAsync(text);
							Logger.WriteLog(msg.Content, text);
							break;
						}

					case "!quokka":
						{
							var text = Quokkapics.GetQuokkaPic();
							msg.Channel.SendMessageAsync(text);
							Logger.WriteLog(msg.Content, text);
							break;
						}

					case "!shibe":
						{
							var text = Shibe.GetShibeImage();
							msg.Channel.SendMessageAsync(text);
							Logger.WriteLog(msg.Content, text);
							break;
						}

					//anime
					case "!8ball":
						{
							var text = CatboyAPI.GetEightBallImage();
							msg.Channel.SendMessageAsync(text);
							Logger.WriteLog(msg.Content, text);
							break;
						}

					case "!baka":
						{
							var text = CatboyAPI.GetBakaGif();
							msg.Channel.SendMessageAsync(text);
							Logger.WriteLog(msg.Content, text);
							break;
						}

					case "!dice":
						{
							var text = CatboyAPI.GetDice();
							msg.Channel.SendMessageAsync(text);
							Logger.WriteLog(msg.Content, text);
							break;
						}
					
					//entertainment
					case "!chuck":
						{
							var text = ChuckNorris.GetChuckJoke();
							msg.Channel.SendMessageAsync(text);
							Logger.WriteLog(msg.Content, text);
							break;
						}

					//personality
					case "!advice":
						{
							var text = AdviceSlipAPI.GetAdvice();
							msg.Channel.SendMessageAsync(text);
							Logger.WriteLog(msg.Content, text);
							break;

						}

					case "!affirmation":
						{
							var text = AffirmationsAPI.GetAffirmation();
							msg.Channel.SendMessageAsync(text);
							Logger.WriteLog(msg.Content, text);
							break;
						}
				}
			}

			return Task.CompletedTask;
		}
	}
}
