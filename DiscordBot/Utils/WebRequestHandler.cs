namespace DiscordBot.Utils
{
    internal class WebRequestHandler
    {
	    public static string GetWebResponse(string url)
        {
            var httpClient = new HttpClient();
            var response = httpClient.GetStringAsync(url);
            response.Wait();
            if (response.IsCompletedSuccessfully)
            {
	            var result = response.Result;
                return result;
			}

			throw new HttpRequestException($"The http response wasn't completed successfully on url: {url}");
		}
    }
}
