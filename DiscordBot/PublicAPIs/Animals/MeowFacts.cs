using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DiscordBot.Helper;
using DiscordBot.Models.Animals.DogAPI;
using DiscordBot.Models.Animals.MeowFacts;
using Newtonsoft.Json;

namespace DiscordBot.PublicAPIs.Animals
{
	internal class MeowFacts
	{
		public static string MeowFact()
		{
			var url = "https://meowfacts.herokuapp.com/";
			var response = Utils.GetWebResponse(url);
			var deserializedResponse = JsonConvert.DeserializeObject<MeowFact>(response);
			return deserializedResponse.data[0];
		}
	}
}
