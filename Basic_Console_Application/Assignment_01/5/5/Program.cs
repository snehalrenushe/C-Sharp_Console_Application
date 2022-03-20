//5. Write a program to check whether it is odd or even
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
            int iNo = 0;

            Console.Write("\nEnter any Number : ");

            iNo = int.Parse(Console.ReadLine());

            if (iNo % 2 == 0)
            {     
                Console.WriteLine(iNo + " is a Even Number");
            }
            else
            {
                Console.WriteLine(iNo + " is a Odd Number.");
            }

            Console.ReadKey();
        }
    }
}
