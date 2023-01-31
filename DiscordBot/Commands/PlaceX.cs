namespace DiscordBot.Commands
{
	internal class PlaceX
	{
		public static string PlaceBear(int width, int height)
		{
			var url = $"https://placebear.com/g/{width}/{height}";
			return url;
		}

		public static string PlaceDog(int width, int height)
		{
			if (width > 3048 || height > 3048)
			{
				return "Please provide a width and height below 3048 pixels";
			}
			var url = $"https://place.dog/{width}/{height}";
			return url;
		}

		public static string PlaceKitten(int width, int height)
		{
			var url = $"https://placekitten.com/g/{width}/{height}";
			return url;
		}
	}
}
