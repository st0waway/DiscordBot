using System.Net;

namespace DiscordBot.Helper
{
    public class Utils
    {
        const double poundsPerKg = 2.2046226218;


        public static string GetWebResponse(string url)
        {
            var request = (HttpWebRequest)WebRequest.Create(url);
            var httpWebResponse = (HttpWebResponse)request.GetResponse();

            using StreamReader streamReader = new StreamReader(httpWebResponse.GetResponseStream());
            return streamReader.ReadToEnd();
        }

        public static string GetCommands()
        {
            var helpText = "Animals: \n" +
                           "!cat - get a random image of a cat \n" +
                           "!dog - get a random image of a dog \n" +
						   "!dogfact - get a random dog fact \n" +
						   "!duck - get a random image of a duck \n" +
						   "!fox - get a random image of a fox \n" +
                           "!meowfact - get a random fact about cats\n" +
                           "!quokka - get a random image of a quokka\n\r" +
						   "Anime: \n" +
                           "!baka - get an animated image of a person screaming baka \n" +
                           "!dice - roll a die \n" +
                           "!8ball - roll an 8ball \n\r" +
                           "Personality: \n" +
                           "!affirmation - get an affirmation \n" +
                           "!advice - get an advice slip \n\r" +
                           "Conversion: \n" +
						   "!kg x - get the amount of pounds in x kgs \n" +
                           "!pounds x - get the amount of kgs in x pounds \n";
            return helpText;
        }

        public static double PoundsToKgConversion(int pounds)
        {
            var kg = Math.Round(pounds / poundsPerKg, 2);
            return kg;
        }

        public static double KgToPoundsConversion(int kgs)
        {
            var pounds = Math.Round(kgs * poundsPerKg, 0);
            return pounds;
        }


    }
}
