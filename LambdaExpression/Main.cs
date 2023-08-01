namespace LambdaExpression
{
    public class Main
    {
        static void Main(string[] args)
        {
            var books = new BookRepository().GetBooks();

            // without lambda expression
            // var cheapBooks = books.FindAll(IsCheaperThan10Dollars);

            var cheapBooks = books.FindAll(b => b.Price < 10);

            foreach (var book in cheapBooks)
            {
                Console.WriteLine(book.Title);
            }

        }

        static bool IsCheaperThan10Dollars(Book book)
        {
            return book.Price < 10;
        }
    }
}