using System;
namespace LINQ
{
	public class Book
	{
		public string Title { get; set; } = "";
		public float Price { get; set; }

        public override string ToString()
        {
            return $"Title = {Title}, Price = {Price}";

        }
    }

	
}

