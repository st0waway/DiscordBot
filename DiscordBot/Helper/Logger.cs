using System.Configuration;

namespace DiscordBot.Helper
{
	public static class Logger
	{
		public static void WriteLog(string message)
		{
			var logPath = ConfigurationManager.AppSettings["logPath"]!;
			using (StreamWriter writer = new StreamWriter(logPath, true))
			{
				writer.WriteLine($"Time: {DateTime.Now}; {message}");
			}
		}

		public static void WriteLog(string caller, string channel, string message)
		{
			var logPath = ConfigurationManager.AppSettings["logPath"]!;
			using (StreamWriter writer = new StreamWriter(logPath, true))
			{
				writer.WriteLine($"Time: {DateTime.Now}; Caller: {caller}; Channel: {channel}; Bot response: {message}");
			}
		}
	}
}
