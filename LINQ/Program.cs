using System;
using System.Linq;

namespace LINQ
{
	public class Program
	{
		public static void Main(string[] args)
		{
			var books = new BookRepository().GetBooks();

			// Linq Query Operators
			var cheaperBooks = from b in books
							   where b.Price < 10
							   orderby b.Title
							   select b;

			// Linq Extension Method
			var cheapBooksTitle = books
								.Where(b => b.Price < 10)
								.OrderBy(b => b.Title)
								.Select(b => b.Title);

			var singleBook = books.Single(b => b.Title == "Physics");
			Console.WriteLine("SingleBook	" + singleBook?.ToString());

			var singleOrDefault = books.SingleOrDefault(b => b.Title == "Maths");
            Console.WriteLine("singleOrDefault	" + singleOrDefault?.ToString());

            var firstBook = books.First(b => b.Price == 10.5f);
            Console.WriteLine("firstBook	" + firstBook?.ToString());

            var firstOrDefault = books.FirstOrDefault(b => b.Price == 11.5f);
            Console.WriteLine("firstOrDefault	" + firstOrDefault?.ToString());

            var lastBook = books.Last(b => b.Price == 10.5f);
            Console.WriteLine("lastBook	" + lastBook?.ToString());

            var lastOrDefault = books.LastOrDefault(b => b.Price == 11.5f);
            Console.WriteLine("lastOrDefault	" + lastOrDefault?.ToString());

            var skipBooks = books.Skip(2).Take(3);

			var maxPrice = books.Max(b => b.Price);
            Console.WriteLine("maxPrice	" + maxPrice.ToString());

            var minPrice = books.Min(b => b.Price);
            Console.WriteLine("minPrice	" + minPrice.ToString());

            var sumPrice = books.Sum(b => b.Price);
            Console.WriteLine("sumPrice	" + sumPrice.ToString());

            var avgPrice = books.Average(b => b.Price);
            Console.WriteLine("avgPrice	" + avgPrice.ToString());

            var bookCount = books.Count();
            Console.WriteLine("bookCount	" + bookCount.ToString());
        }
	}
}

