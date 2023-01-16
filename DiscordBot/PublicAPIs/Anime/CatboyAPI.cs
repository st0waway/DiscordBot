using DiscordBot.Helper;
using DiscordBot.Models.Anime.CatboyAPI;
using Newtonsoft.Json;

namespace DiscordBot.PublicAPIs.Anime;

public class CatboyAPI
{
	public static string Baka()
	{
		var url = "https://api.catboys.com/baka";
		var response = Utils.GetWebResponse(url);
		var baka = JsonConvert.DeserializeObject<BakaGifReposnse>(response);
		return baka.Url;
	}

	public static string Dice()
	{
		var url = "https://api.catboys.com/dice";
		var response = Utils.GetWebResponse(url);
		var dice = JsonConvert.DeserializeObject<DiceImageResponse>(response);
		return dice.Url;
	}

	public static string EightBall()
	{
		var url = "https://api.catboys.com/8ball";
		var response = Utils.GetWebResponse(url);
		var eightBall = JsonConvert.DeserializeObject<DiceImageResponse>(response);
		return eightBall.Url;
	}
}