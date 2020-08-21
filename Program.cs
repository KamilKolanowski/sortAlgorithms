using System;

namespace Algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            var algorithms = new Algorithms(@"C:\Users\tanss\Desktop\");

            algorithms.Run("first", 0, 2, 10000, 30, false);
            algorithms.Run("second", int.MinValue, int.MaxValue, 10000, 30, false);
            algorithms.Run("third", int.MinValue, int.MaxValue, 10000, 30, true);
        }
    }
}