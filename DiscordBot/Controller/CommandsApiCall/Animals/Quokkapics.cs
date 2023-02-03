﻿using DiscordBot.Controller.Utils;
using DiscordBot.Model.Animals.Quokka.pics;
using Newtonsoft.Json;

namespace DiscordBot.Controller.CommandsApiCall.Animals
{
    internal class Quokkapics
    {
        public static string GetQuokkaPic()
        {
            const string url = "https://quokka.pics/api/";
            var response = WebRequestHandler.GetWebResponse(url);
            var deserializedResponse = JsonConvert.DeserializeObject<QuokkaImageResponse>(response);
            if (deserializedResponse?.Image != null)
            {
                return deserializedResponse.Image;
            }

            Logger.WriteLog("The deserialized response was null");
            throw new NullReferenceException("The deserialized response was null");
        }
    }
}