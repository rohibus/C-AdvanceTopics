using System;
namespace LINQ
{
	public class BookRepository
	{
		public List<Book> GetBooks()
		{
			return new List<Book>()
			{
				new Book()
				{
					Title = "Maths",
					Price = 5.5f
				},
                new Book()
                {
                    Title = "Physics",
                    Price = 8.5f
                },
                new Book()
                {
                    Title = "Chemistry",
                    Price = 10.5f
                },
                new Book()
                {
                    Title = "ComputerScience",
                    Price = 11.5f
                },
                new Book()
                {
                    Title = "Kannada",
                    Price = 12.5f
                }
            };
		}
	}
}

