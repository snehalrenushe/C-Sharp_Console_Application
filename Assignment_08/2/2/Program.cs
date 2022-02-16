//2. Write a program in C# Sharp to display the n terms of odd natural number and their sum.
//Ex:
//Input :
//Input number of terms : 10
//Output :
//The odd numbers are :1 3 5 7 9 
//The Sum of odd Natural Number upto 10 terms : 25

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
            int i, n, sum = 0;

            Console.Write("\n\n");
            Console.Write("Display n terms of natural number and their sum:\n");
            Console.Write("\n\n");

            Console.Write("Input Value of terms : ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nThe first {0} natural number are :\n", n);
            for (i = 1; i <= n; i++)
            {
                if (i % 2 == 1)
                {
                    Console.Write("{0} ", i);
                    sum += i;
                }
            }

            Console.Write("\nThe Sum of Natural Number upto {0} terms : {1} \n", n, sum);

            Console.ReadKey();
        }
    }
}
