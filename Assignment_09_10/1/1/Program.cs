//1. Write a program using WriteLine(Boolean) method in c#

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
            Random rnd = new Random();
            int[] numbers = new int[10];
            for (int ctr = 0; ctr <= numbers.GetUpperBound(0); ctr++)
            {
                numbers[ctr] = rnd.Next();
            }

            foreach (var number in numbers)
            {
                bool even = (number % 2 == 0);
                Console.WriteLine("Is {0} even:", number);
                Console.WriteLine(even);
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
