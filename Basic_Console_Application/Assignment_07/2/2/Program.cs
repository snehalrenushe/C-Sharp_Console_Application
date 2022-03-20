//2. Write a C# Sharp program to find whether a given year is a leap year or not.
//Ex:
//Input : 2016
//Output : 2016 is leap year

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            int iNo;

            Console.WriteLine("Enter a Year : ");
            iNo = Convert.ToInt32(Console.ReadLine());

            if ((iNo % 4 == 0 ) && (iNo % 400 == 0) || (iNo % 100 != 0))
            {
                Console.WriteLine("Given Year is Leap Year.");
            }
            else
            {
                Console.WriteLine("Given Year is not Leap Year.");
            }

            Console.ReadKey();
        }
    }
}
