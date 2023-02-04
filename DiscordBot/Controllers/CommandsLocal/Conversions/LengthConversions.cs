namespace DiscordBot.Controllers.CommandsLocal.Conversions
{
    internal class LengthConversions
    {
        public static string InchToCmConversion(double inch)
        {
            var cm = inch * TemperatureConversions.CentimetersPerInch;
            return $"{Math.Round(cm, 2)}cm";
        }

        public static string CmToInchConversion(double cm)
        {
            var inch = cm / TemperatureConversions.CentimetersPerInch;
            return $"{Math.Round(inch, 2)}inches";
        }
    }
}
