//6. Write a program to swap 2 numbers
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _6
{
    class Program
    {
        static void Main(string[] args)
        {
            int iNo1,iNo2;

            Console.Write("Enter first Number : ");
            iNo1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Second Number : ");
            iNo2 = Convert.ToInt32(Console.ReadLine());

            iNo1 = iNo1 + iNo2;
            iNo2 = iNo1 - iNo2;
            iNo1 = iNo1 - iNo2;

            Console.Write("After Swapping :" + iNo1 + " " + iNo2);

            Console.ReadKey();
        }
    }
}
