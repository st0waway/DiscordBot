namespace DiscordBot.Controllers.CommandsLocal.Conversions
{
    internal class WeightConversions
    {
        private const double PoundsPerKg = 2.2046226218;

        public static string PoundsToKgConversion(int pounds)
        {
            var kg = Math.Round((double)(pounds / PoundsPerKg), 2);
            return $"{kg} kg";
        }

        public static string KgToPoundsConversion(int kgs)
        {
            var pounds = Math.Round((double)(kgs * PoundsPerKg), 0);
            return $"{pounds} pounds";
        }
    }
}
