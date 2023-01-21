namespace DiscordBot.Helper
{
	internal class UnitConversions
	{
		const double PoundsPerKg = 2.2046226218;
		const double CentimetersPerInch = 2.54;

		public static string PoundsToKgConversion(int pounds)
		{
			var kg = Math.Round(pounds / PoundsPerKg, 2);
			return $"{kg} kg";
		}

		public static string KgToPoundsConversion(int kgs)
		{
			var pounds = Math.Round(kgs * PoundsPerKg, 0);
			return $"{pounds} pounds";
		}

		public static string FahrenheitToCelsiusConversion(double fahrenheit)
		{
			var celsius = (fahrenheit - 32) * 5 / 9;
			return $"{Math.Round(celsius, 1)}°C";
		}

		public static string CelsiusToFahrenheitConversion(double celsius)
		{
			var fahrenheit = (celsius * 1.8) + 32;
			return $"{Math.Round(fahrenheit, 1)}°F";
		}

		public static string InchToCmConversion(double inch)
		{
			var cm = inch * CentimetersPerInch;
			return $"{Math.Round(cm, 2)}cm";
		}

		public static string CmToInchConversion(double cm)
		{
			var inch = cm / CentimetersPerInch;
			return $"{Math.Round(inch, 2)}inches";
		}
	}
}
