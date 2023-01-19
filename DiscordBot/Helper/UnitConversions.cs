namespace DiscordBot.Helper
{
	internal class UnitConversions
	{
		const double PoundsPerKg = 2.2046226218;
		const double CentimetersPerInch = 2.54;

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
	}
}
