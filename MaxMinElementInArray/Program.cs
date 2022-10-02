using System;
using System.Linq;

namespace MaxMinElementInArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new[] { 2, 43, 5, 324, 5, 21, 5, 2 };
            Console.WriteLine($"Max number is: {array.Max()}");
            Console.WriteLine($"Min number is: {array.Min()}");
        }
    }
}