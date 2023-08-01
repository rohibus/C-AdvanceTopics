using System;
namespace LambdaExpression
{
    public class Program
    {
        static void Main(string[] args)
        {
            // lambda expression is [args => expression]
            /*  for no argument
                    () => expression
                for one argument
                    x => expression
                for multiple argument
                    (x, y, z) => expression
            */

            Func<int, int> square = number => number * number;
            System.Console.WriteLine(square(5));

            const int factor = 5;
            Func<int, int> multiplier = number => number * factor;
            var result = multiplier(10);
            System.Console.WriteLine(result);
        }
    }
}