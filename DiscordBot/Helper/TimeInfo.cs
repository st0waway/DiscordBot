using System.Globalization;

namespace DiscordBot.Helper
{
	internal class TimeInfo
	{
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
