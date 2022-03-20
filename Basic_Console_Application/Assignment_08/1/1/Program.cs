//1. Write a program in C# Sharp to display n terms of natural number and their sum.
//Ex:
//Input :
//Enter number of natural terms do you want
//Output :
//The first 7 natural number is :
//1 2 3 4 5 6 7
//The Sum of Natural Number upto 7 terms : 28

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
            int i, n, sum = 0;

            Console.Write("\n\n");
            Console.Write("Display n terms of natural number and their sum:\n");
            Console.Write("\n\n");

            Console.Write("Input Value of terms : ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nThe first {0} natural number are :\n", n);
            for (i = 1; i <= n; i++)
            {
                Console.Write("{0} ", i);
                sum += i;
            }

            Console.Write("\nThe Sum of Natural Number upto {0} terms : {1} \n", n, sum);

            Console.ReadKey();
        }
    }
}
