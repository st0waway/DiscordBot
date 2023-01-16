using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DiscordBot.Helper;
using DiscordBot.Models.Animals.RandomDogAPI;
using DiscordBot.Models.Animals.RandomFoxAPI;
using Newtonsoft.Json;

namespace DiscordBot.PublicAPIs.Animals
{
	internal class RandomDogAPI
	{
		public static string RandomDog()
		{
			var url = "https://random.dog/woof.json";
			var response = Utils.GetWebResponse(url);
			var deserializedResponse = JsonConvert.DeserializeObject<RandomDogResponse>(response);
			return deserializedResponse.Url;
		}
	}
}
