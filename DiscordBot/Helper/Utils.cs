using System.Configuration;
using System.Globalization;
using System.Net;

namespace DiscordBot.Helper
{
	public class Utils
	{
		const double PoundsPerKg = 2.2046226218;
		const double CentimetersPerInch = 2.54;

		public static string GetWebResponse(string url)
		{
			var request = (HttpWebRequest)WebRequest.Create(url);
			var httpWebResponse = (HttpWebResponse)request.GetResponse();
			using StreamReader streamReader = new StreamReader(httpWebResponse.GetResponseStream());
			return streamReader.ReadToEnd();
		}

		public static string GetCommands()
		{
			var reader = new StreamReader(ConfigurationManager.AppSettings["commandsPath"]!);
			var helpText = reader.ReadToEnd();
			return helpText;
		}

		public static double PoundsToKgConversion(int pounds)
		{
			var kg = Math.Round(pounds / PoundsPerKg, 2);
			return kg;
		}

		public static double KgToPoundsConversion(int kgs)
		{
			var pounds = Math.Round(kgs * PoundsPerKg, 0);
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
			var cm = inch * CentimetersPerInch;
			return cm;
		}

		public static double CmToInchConversion(double cm)
		{
			var inch = cm / CentimetersPerInch;
			return inch;
		}

		public static string TimeStowaway()
		{
			var time = DateTime.Now.ToString(CultureInfo.InvariantCulture);
			return time;
		}

		public static string TimeSashimi()
		{
			var time = TimeZoneInfo.ConvertTime(DateTime.Now,
				TimeZoneInfo.FindSystemTimeZoneById("Pacific Standard Time")).ToString(CultureInfo.InvariantCulture);
			return time;
		}

		public static string TimeAniq()
		{
			var time = TimeZoneInfo.ConvertTime(DateTime.Now,
			TimeZoneInfo.FindSystemTimeZoneById("Tokyo Standard Time")).ToString(CultureInfo.InvariantCulture);
			return time;
		}
	}
}
