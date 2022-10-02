using System;
using System.Collections.Generic;

namespace SortAscDscArray
{
    class Program
    {
        static void Main(string[] args)
        {
            // khai báo biến chứa số phần tử cần sắp xếp
            int numberElementOfList;
            // khai báo list dùng để chứa các số người dùng nhập
            List<int> listNumber = new List<int>();

            // hỏi người dùng cần nhập vào bao nhiêu số
            Console.WriteLine("Input number of element you want to sort");
            numberElementOfList = Convert.ToInt32(Console.ReadLine());
            
            // tiến hành lấy các giá trị người dùng nhập vào
            Console.WriteLine($"Let's input {numberElementOfList} elements to sort:");
            for (int i = 1; i <= numberElementOfList; i++)
            {
                Console.WriteLine($"Input number {i} is: ");
                var input = Convert.ToInt32(Console.ReadLine());
                listNumber.Add(input);
            }

            // print out number in list
            Console.WriteLine("-----------Input-----------");
            foreach (var number in listNumber)
            {
                Console.WriteLine(number);
            }
            
            Console.WriteLine("-----------Sort Asc-----------");
            listNumber.Sort(); // sort tang dan
            foreach (var number in listNumber)
            {
                Console.WriteLine(number);
            }
            
            Console.WriteLine("-----------Sort Dsc-----------");
            listNumber.Reverse(); // sort giam dan
            foreach (var number in listNumber)
            {
                Console.WriteLine(number);
            }
        }
    }
}