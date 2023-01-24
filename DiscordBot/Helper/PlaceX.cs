namespace DiscordBot.Helper
{
	internal class PlaceX
	{
		public static string PlaceKitten(int width, int height)
		{
			var url = $"https://placekitten.com/g/{width}/{height}";
			return url;
		}
	}
}
