using System;
using System.Linq;

namespace PrintOutDistinctList
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new[] { 2, 43, 5, 324, 5, 21, 5, 2 };
            int[] arrayDistinct = array.Distinct().ToArray();

            foreach (var number in arrayDistinct)
            {
                Console.WriteLine(number);
            }
        }
    }
}