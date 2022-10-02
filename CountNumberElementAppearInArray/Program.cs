using System;
using System.Collections.Generic;
using System.Linq;

namespace CountNumberElementAppearInArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new[] { 2, 43, 5, 324, 5, 21, 5, 2 };
            int[] arrayDistinct = array.Distinct().ToArray(); // 2 - 43 - 5 - 324 - 21

            foreach (var numberDistinct in arrayDistinct)
            {
                int count = 0;
                foreach (var number in array)
                {
                    if (numberDistinct == number)
                    {
                        count++;
                    }
                }

                Console.WriteLine($"Number {numberDistinct} appears is: {count}");
                count = 0;
            }
        }
    }
}