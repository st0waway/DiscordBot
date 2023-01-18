﻿using System.Net;

namespace DiscordBot.Helper
{
	public class Utils
	{
		const double poundsPerKg = 2.2046226218;
		const double centimetersPerInch = 2.54;



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
						   "!quokka - get a random image of a quokka\n" +
						   "!shibe - get a random image of a shibe\n\r" +
						   "Anime: \n" +
						   "!baka - get an animated image of a person screaming baka \n" +
						   "!dice - roll a die \n" +
						   "!8ball - roll an 8ball \n\r" +
						   "Personality: \n" +
						   "!affirmation - get an affirmation \n" +
						   "!advice - get an advice slip \n\r" +
						   "Conversion: \n" +
						   "!kg x - get the amount of pounds in x kgs \n" +
						   "!pounds x - get the amount of kgs in x pounds \n" +
						   "!сelsius x - get the fahrenheit equivalent temperature of x \n" +
						   "!fahrenheit x - get the celsius equivalent temperature of x \n" +
						   "!cm x - get the inch equivalent length of x \n" +
						   "!inches x - get the cm equivalent length of x \n" +
						   "!timestow - get st0waway's time\n";
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

		public static double FahrenheitToCelsiusConversion(double fahrenheit)
		{
			var celsius = (fahrenheit - 32) * 5 / 9;
			return celsius;
		}

		public static double CelsiusToFahrenheitConversion(double celsius)
		{
			var fahrenheit = (celsius * 1.8) + 32;
			return fahrenheit;
		}

		public static double InchToCmConversion(double inch)
		{
			var cm = inch * centimetersPerInch;
			return cm;
		}

		public static double CmToInchConversion(double cm)
		{
			var inch = cm / centimetersPerInch;
			return inch;
		}

		public static string TimeStowaway()
		{
			var time = DateTime.Now.ToString();
			return time;
		}

		public static string TimeSashimi()
		{
			var time = TimeZoneInfo.ConvertTime(DateTime.Now,
				TimeZoneInfo.FindSystemTimeZoneById("Pacific Standard Time")).ToString();
			return time;

		}
	}
}
