//1. Write a C# Sharp program to check whether a given number is positive or negative.
//Ex:
//Input : 14 Output : 14 is a positive number

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            int iNo;

            Console.WriteLine("Enter a Number : ");
            iNo = Convert.ToInt32(Console.ReadLine());

            if (iNo == 0)
            {
                Console.WriteLine("Given number is zero.");
            }
            else if (iNo > 0)
            {
                Console.WriteLine("Given number is Positive.");
            }
            else
            {
                Console.WriteLine("Given number is Negative.");
            }

            Console.ReadKey();
        }
    }
}
