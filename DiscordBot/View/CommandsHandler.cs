using Discord.WebSocket;

using DiscordBot.Controller.CommandsApiCall.Animals;
using DiscordBot.Controller.CommandsApiCall.Anime;
using DiscordBot.Controller.CommandsApiCall.Entertainment;
using DiscordBot.Controller.CommandsApiCall.Personality;
using DiscordBot.Controller.CommandsLocal;
using DiscordBot.Controller.CommandsLocal.Conversions;
using DiscordBot.Controller.Utils;

namespace DiscordBot.View
{
	internal class CommandsHandler
	{
		public static Task HandleCommandsWithArguments(SocketMessage msg)
		{
			if (msg.Author.IsBot) return Task.CompletedTask;
			if (msg.Content.Contains("!kg"))
			{
				var kg = int.Parse(msg.Content.Split(' ')[1]);
				var text = WeightConversions.KgToPoundsConversion(kg);
				msg.Channel.SendMessageAsync(text);
				Logger.WriteLog(msg.Content, text);
			}

			if (msg.Content.Contains("!pounds"))
			{
				var pounds = int.Parse(msg.Content.Split(' ')[1]);
				var text = WeightConversions.PoundsToKgConversion(pounds);
				msg.Channel.SendMessageAsync(text);
				Logger.WriteLog(msg.Content, text);
			}

			if (msg.Content.Contains("!fahrenheit"))
			{
				var fahrenheit = int.Parse(msg.Content.Split(' ')[1]);
				var text = TemperatureConversions.FahrenheitToCelsiusConversion(fahrenheit);
				msg.Channel.SendMessageAsync(text);
				Logger.WriteLog(msg.Content, text);
			}

			if (msg.Content.Contains("!celsius"))
			{
				var celsius = int.Parse(msg.Content.Split(' ')[1]);
				var text = TemperatureConversions.CelsiusToFahrenheitConversion(celsius);
				msg.Channel.SendMessageAsync(text);
				Logger.WriteLog(msg.Content, text);
			}

			if (msg.Content.Contains("!cm"))
			{
				var cm = int.Parse(msg.Content.Split(' ')[1]);
				var text = LengthConversions.CmToInchConversion(cm);
				msg.Channel.SendMessageAsync(text);
				Logger.WriteLog(msg.Content, text);
			}

			if (msg.Content.Contains("!inches"))
			{
				var inches = int.Parse(msg.Content.Split(' ')[1]);
				var text = LengthConversions.InchToCmConversion(inches);
				msg.Channel.SendMessageAsync(text);
				Logger.WriteLog(msg.Content, text);
			}

			if (msg.Content.Contains("!placebear"))
			{
				var width = int.Parse(msg.Content.Split(' ')[1]);
				var height = int.Parse(msg.Content.Split(' ')[2]);
				var text = PlaceX.PlaceBear(width, height);
				msg.Channel.SendMessageAsync(text);
				Logger.WriteLog(msg.Content, text);
			}

			if (msg.Content.Contains("!placedog"))
			{
				var width = int.Parse(msg.Content.Split(' ')[1]);
				var height = int.Parse(msg.Content.Split(' ')[2]);
				var text = PlaceX.PlaceDog(width, height);
				msg.Channel.SendMessageAsync(text);
				Logger.WriteLog(msg.Content, text);
			}

			if (msg.Content.Contains("!placekitten"))
			{
				var width = int.Parse(msg.Content.Split(' ')[1]);
				var height = int.Parse(msg.Content.Split(' ')[2]);
				var text = PlaceX.PlaceKitten(width, height);
				msg.Channel.SendMessageAsync(text);
				Logger.WriteLog(msg.Content, text);
			}

			return Task.CompletedTask;
		}

		public static Task HandleCommands(SocketMessage msg)
		{
			//conversions
			if (msg.Author.IsBot) return Task.CompletedTask;
			switch (msg.Content)
			{
				//commands
				case "!commands":
					{
						var text = CommandsList.GetCommandsList();
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
						var text = RandomDogApi.GetRandomDog();
						msg.Channel.SendMessageAsync(text);
						Logger.WriteLog(msg.Content, text);
						break;
					}

				case "!dogfact":
					{
						var text = DogApi.GetDogFact();
						msg.Channel.SendMessageAsync(text);
						Logger.WriteLog(msg.Content, text);
						break;
					}

				case "!duck":
					{
						var text = RandomDuckApIv2.GetRandomDuck();
						msg.Channel.SendMessageAsync(text);
						Logger.WriteLog(msg.Content, text);
						break;
					}

				case "!fox":
					{
						var text = RandomFoxApi.GetRandomFox();
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
						var text = CatBoyApi.GetEightBallImage();
						msg.Channel.SendMessageAsync(text);
						Logger.WriteLog(msg.Content, text);
						break;
					}

				case "!baka":
					{
						var text = CatBoyApi.GetBakaGif();
						msg.Channel.SendMessageAsync(text);
						Logger.WriteLog(msg.Content, text);
						break;
					}

				case "!dice":
					{
						var text = CatBoyApi.GetDice();
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

				case "!uselessfact":
					{
						var text = RandomUselessFacts.GetRandomUselessFact();
						msg.Channel.SendMessageAsync(text);
						Logger.WriteLog(msg.Content, text);
						break;
					}

				//personality
				case "!advice":
					{
						var text = AdviceSlipApi.GetAdvice();
						msg.Channel.SendMessageAsync(text);
						Logger.WriteLog(msg.Content, text);
						break;

					}

				case "!affirmation":
					{
						var text = AffirmationsApi.GetAffirmation();
						msg.Channel.SendMessageAsync(text);
						Logger.WriteLog(msg.Content, text);
						break;
					}
			}

			return Task.CompletedTask;
		}
	}
}
