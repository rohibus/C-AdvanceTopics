using System;

namespace Generics
{
    public class BookList
    {
        public void Add(Book book)
        {
            throw new NotImplementedException();
        }

        public Book this[int index]
        {
            get { throw new NotImplementedException(); }
        }
    }

    public class GenericList<T>
    {
        public void Add(T value)
        {
            throw new NotImplementedException();
        }

        public T this[int index]
        {
            get { throw new NotImplementedException(); }
        }
    }

    public class GenericDictionary<TKey, TValue>
    {
        public void Add(TKey key, TValue value)
        {

        }
    }

    public static void Main(string[] args)
    {
        var book = new Book { Author = "Nulan", price = 10.0 };

        var numbers = new GenericList<int>();
        numbers.Add(10);

        var books = new GenericList<Book>();
        books.Add(book);

        var dictionary = new GenericDictionary<string, Book>();
        dictionary.Add("Nulan", book);
    }
}