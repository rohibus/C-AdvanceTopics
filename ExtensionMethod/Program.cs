using System;
namespace ExtensionMethod
{
	public class Program
	{
		public static void Main(string[] args)
		{
			string post = "This is suppose to be very long blog post, we haver to shorten it";
			string shortedPost = post.Shorten(5);
			Console.WriteLine(shortedPost);
		}
	}
}

