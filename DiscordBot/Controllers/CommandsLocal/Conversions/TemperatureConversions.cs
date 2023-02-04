namespace DiscordBot.Controllers.CommandsLocal.Conversions
{
    internal class TemperatureConversions
    {
        public const double CentimetersPerInch = 2.54;

        public static string FahrenheitToCelsiusConversion(double fahrenheit)
        {
            var celsius = (fahrenheit - 32) * 5 / 9;
            return $"{Math.Round(celsius, 1)}°C";
        }

        public static string CelsiusToFahrenheitConversion(double celsius)
        {
            var fahrenheit = celsius * 1.8 + 32;
            return $"{Math.Round(fahrenheit, 1)}°F";
        }
    }
}
