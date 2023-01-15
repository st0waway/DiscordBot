using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DiscordBot.Helper;
using DiscordBot.Models.Animals.Cataas;
using DiscordBot.Models.Animals.DogAPI;
using Newtonsoft.Json;

namespace DiscordBot.PublicAPIs.Animals
{
	internal class Cataas
	{
		public static string GetCatImage()
		{
			var url = "https://cataas.com/cat?json=true";
			var response = Utils.GetWebResponse(url);
			var deserializedResponse = JsonConvert.DeserializeObject<CataasResponse>(response);
			return "https://cataas.com" + deserializedResponse.Url;
		}
	}
}
