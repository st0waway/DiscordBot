using System.Net;

namespace DiscordBot.Utils
{
    internal class WebRequestHandler
    {
	    public static string GetWebResponse(string url)
        {
            var httpClient = new HttpClient();
            var response = httpClient.GetStringAsync(url);
            response.Wait();
            if (response.IsCompleted)
            {
                var result = response.Result;
                return result;
			}

			throw new Exception("error");
		}
    }
}
