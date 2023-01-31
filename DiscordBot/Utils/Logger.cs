using System.Configuration;

namespace DiscordBot.Utils
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

        public static void WriteLog(string command, string response)
        {
            var logPath = ConfigurationManager.AppSettings["logPath"]!;
            using (StreamWriter writer = new StreamWriter(logPath, true))
            {
                writer.WriteLine($"Time: {DateTime.Now}; Command: {command}; Bot response: {response}");
            }
        }

        public static void WriteLog(string caller, string channel, string command, string response)
        {
            var logPath = ConfigurationManager.AppSettings["logPath"]!;
            using (StreamWriter writer = new StreamWriter(logPath, true))
            {
                writer.WriteLine($"Time: {DateTime.Now}; Caller: {caller}; Channel: {channel}; Command: {command}; Bot response: {response}");
            }
        }
    }
}
