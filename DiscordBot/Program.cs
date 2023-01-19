﻿using System.Configuration;

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
			//conversions
			if (!msg.Author.IsBot)
			{
				if (msg.Content.Contains("!kg"))
				{
					Int32.TryParse(msg.Content.Split(' ')[1], out var kg);
					var pounds = UnitConversions.KgToPoundsConversion(kg);
					var text = $"{pounds} pounds";
					Logger.WriteLog(msg.Author.ToString(), msg.Channel.ToString()!, msg.Content, text);
					msg.Channel.SendMessageAsync(text);
				}

				if (msg.Content.Contains("!pounds"))
				{
					Int32.TryParse(msg.Content.Split(' ')[1], out var pounds);
					var kg = UnitConversions.PoundsToKgConversion(pounds);
					var text = $"{kg} kg";
					Logger.WriteLog(msg.Author.ToString(), msg.Channel.ToString()!, msg.Content, text);
					msg.Channel.SendMessageAsync(text);
				}
				
				if (msg.Content.Contains("!fahrenheit"))
				{
					Int32.TryParse(msg.Content.Split(' ')[1], out var fahrenheit);
					var celsius = UnitConversions.FahrenheitToCelsiusConversion(fahrenheit);
					var text = $"{Math.Round(celsius, 1)}°C";
					Logger.WriteLog(msg.Author.ToString(), msg.Channel.ToString()!, msg.Content, text);
					msg.Channel.SendMessageAsync(text);
				}

				if (msg.Content.Contains("!celsius"))
				{
					Int32.TryParse(msg.Content.Split(' ')[1], out var celsius);
					var fahrenheit = UnitConversions.CelsiusToFahrenheitConversion(celsius);
					var text = $"{Math.Round(fahrenheit, 1)}°F";
					Logger.WriteLog(msg.Author.ToString(), msg.Channel.ToString()!, msg.Content, text);
					msg.Channel.SendMessageAsync(text);
				}

				if (msg.Content.Contains("!cm"))
				{
					Int32.TryParse(msg.Content.Split(' ')[1], out var cm);
					var inches = UnitConversions.CmToInchConversion(cm);
					var text = $"{Math.Round(inches, 2)}inches";
					Logger.WriteLog(msg.Author.ToString(), msg.Channel.ToString()!, msg.Content, text);
					msg.Channel.SendMessageAsync(text);
				}

				if (msg.Content.Contains("!inches"))
				{
					Int32.TryParse(msg.Content.Split(' ')[1], out var inches);
					var cm = UnitConversions.InchToCmConversion(inches);
					var text = $"{Math.Round(cm, 2)}cm";
					Logger.WriteLog(msg.Author.ToString(), msg.Channel.ToString()!, msg.Content, text);
					msg.Channel.SendMessageAsync(text);
				}

				switch (msg.Content)
				{
					//commands
					case "!commands":
						{
							var text = Utils.GetCommands();
							msg.Channel.SendMessageAsync(text);
							Logger.WriteLog(msg.Author.ToString(), msg.Channel.ToString()!, msg.Content, text);
							break;
						}

					//time
					case "!timestow":
						{
							var text = TimeInfo.TimeStowaway();
							msg.Channel.SendMessageAsync(text);
							Logger.WriteLog(msg.Author.ToString(), msg.Channel.ToString()!, msg.Content, text);
							break;
						}

					case "!timesashimi":
						{
							var text = TimeInfo.TimeSashimi();
							msg.Channel.SendMessageAsync(text);
							Logger.WriteLog(msg.Author.ToString(), msg.Channel.ToString()!, msg.Content, text);
							break;
						}

					case "!timeaniq":
						{
							var text = TimeInfo.TimeAniq();
							msg.Channel.SendMessageAsync(text);
							Logger.WriteLog(msg.Author.ToString(), msg.Channel.ToString()!, msg.Content, text);
							break;
						}

					case "!timewood":
					{
						var text = TimeInfo.TimeWood();
						msg.Channel.SendMessageAsync(text);
						Logger.WriteLog(msg.Author.ToString(), msg.Channel.ToString()!, msg.Content, text);
						break;
					}

					//animals
					case "!cat":
						{
							var text = Cataas.GetCatImage();
							msg.Channel.SendMessageAsync(text);
							Logger.WriteLog(msg.Author.ToString(), msg.Channel.ToString()!, msg.Content, text);
							break;
						}

					case "!dog":
						{
							var text = RandomDogAPI.RandomDog();
							msg.Channel.SendMessageAsync(text);
							Logger.WriteLog(msg.Author.ToString(), msg.Channel.ToString()!, msg.Content, text);
							break;
						}

					case "!dogfact":
						{
							var text = DogAPI.DogFact();
							msg.Channel.SendMessageAsync(text);
							Logger.WriteLog(msg.Author.ToString(), msg.Channel.ToString()!, msg.Content, text);
							break;
						}

					case "!duck":
						{
							var text = RandomDuckAPIv2.RandomDuck();
							msg.Channel.SendMessageAsync(text);
							Logger.WriteLog(msg.Author.ToString(), msg.Channel.ToString()!, msg.Content, text);
							break;
						}

					case "!fox":
						{
							var text = RandomFoxAPI.RandomFox();
							msg.Channel.SendMessageAsync(text);
							Logger.WriteLog(msg.Author.ToString(), msg.Channel.ToString()!, msg.Content, text);
							break;
						}

					case "!meowfact":
						{
							var text = MeowFacts.MeowFact();
							msg.Channel.SendMessageAsync(text);
							Logger.WriteLog(msg.Author.ToString(), msg.Channel.ToString()!, msg.Content, text);
							break;
						}

					case "!quokka":
						{
							var text = Quokkapics.GetQuokkaPic();
							msg.Channel.SendMessageAsync(text);
							Logger.WriteLog(msg.Author.ToString(), msg.Channel.ToString()!, msg.Content, text);
							break;
						}

					case "!shibe":
						{
							var text = Shibe.GetShibeImage();
							msg.Channel.SendMessageAsync(text);
							Logger.WriteLog(msg.Author.ToString(), msg.Channel.ToString()!, msg.Content, text);
							break;
						}

					//anime
					case "!8ball":
						{
							var text = CatboyAPI.EightBall();
							msg.Channel.SendMessageAsync(text);
							Logger.WriteLog(msg.Author.ToString(), msg.Channel.ToString()!, msg.Content, text);
							break;
						}

					case "!baka":
						{
							var text = CatboyAPI.Baka();
							msg.Channel.SendMessageAsync(text);
							Logger.WriteLog(msg.Author.ToString(), msg.Channel.ToString()!, msg.Content, text);
							break;
						}

					case "!dice":
						{
							var text = CatboyAPI.Dice();
							msg.Channel.SendMessageAsync(text);
							Logger.WriteLog(msg.Author.ToString(), msg.Channel.ToString()!, msg.Content, text);
							break;
						}

					//personality
					case "!advice":
						{
							var text = AdviceSlipAPI.Advice();
							msg.Channel.SendMessageAsync(text);
							Logger.WriteLog(msg.Author.ToString(), msg.Channel.ToString()!, msg.Content, text);
							break;

						}

					case "!affirmation":
						{
							var text = AffirmationsAPI.Affirmation();
							msg.Channel.SendMessageAsync(text);
							Logger.WriteLog(msg.Author.ToString(), msg.Channel.ToString()!, msg.Content, text);
							break;
						}


				}
			}

			return Task.CompletedTask;
		}
	}
}
