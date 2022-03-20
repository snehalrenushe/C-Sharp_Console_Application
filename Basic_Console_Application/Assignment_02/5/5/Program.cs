//Write a program by taking two integer values and return the value by adding in the
//Output
//Ex: Input : 5,4
//Output : 9
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _5
{
    class Program
    {
        static void Main(string[] args)
        {
            int iNo1, iNo2,iSum;

            Console.Write("Enter a first number : ");
            iNo1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter a second number : ");
            iNo2 = Convert.ToInt32(Console.ReadLine());

            iSum = iNo1 + iNo2;

            Console.Write(iSum);

            Console.ReadKey();
            
        }
    }
}
