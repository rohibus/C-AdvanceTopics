using System;
namespace Generics
{
    // where T : IComparable 
    // where T : Product 
    // where T : struct 
    // where T : class 
    // where T : new() 

    public class Utilities
    {
        public int Max(int a, int b)
        {
            return a > b ? a : b;
        }

        public T Max<T>(T a, T b) where T : IComparable
        {
            return a.CompareTo(b) > 0 ? a : b;
        }
    }

    // public class Utilities<T> where T : IComparable 
    // {
    //     public int Max(int a, int b)
    //     {
    //         return a > b ? a : b;
    //     }

    //     public T Max(T a, T b)
    //     {
    //         return a.CompareTo(b) > 0 ? a : b;
    //     }
    // }
}