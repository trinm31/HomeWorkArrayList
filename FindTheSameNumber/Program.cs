using System;
using System.Collections.Generic;
using System.Linq;

namespace FindTheSameNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new[] { 2, 43, 5, 324, 5, 21, 5, 2 };
            //int[] array = new[] { 2, 43, 5, 324, 5, 21, 5, 2 };
            List<int> distinctNumber = new List<int>();
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length; j++)
                {
                    if (i!=j && array[i] == array[j])
                    {
                        distinctNumber.Add(array[i]);
                    }
                }
            }

            foreach (var number in distinctNumber.Distinct())
            {
                Console.WriteLine(number);
            }
        }
    }
}