namespace Generics
{
    public class Nullable<T> where T : struct
    {
        private object _value;

        public Nullable(T value)
        {
            _value = value;
        }

        public Nullable()
        {
        }

        public bool HasValue => _value != null;

        public T GetValueOrDefault()
        {
            if (HasValue)
            {
                return (T) _value;
            }

            return default(T);
        }

        public static void Main(string[] args)
        {
            var number = new Nullable<int>();
            Console.WriteLine("Has Value " + number.HasValue); // false
            System.Console.WriteLine("Value " + number.GetValueOrDefault());

            var number = new Nullable<int>(10);
            Console.WriteLine("Has Value " + number.HasValue); // true
            System.Console.WriteLine("Value " + number.GetValueOrDefault());
        }
    }
}