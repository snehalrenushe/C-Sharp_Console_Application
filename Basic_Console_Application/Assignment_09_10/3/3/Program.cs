﻿//3. Write a method of Calculator and print sum and product in c#
//Ex:
//Input :
//enter a and b values
//Output :
//sum = 12 and product = 36

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _3
{
    class Program
    {
        public static int Sum(int num1, int num2)
        {
            int total;
            total = num1 + num2;
            return total;
        }

        public static int Prod(int num1, int num2)
        {
            int mult;
            mult = num1 * num2;
            return mult;
        }

        static void Main(string[] args)
        {
            Console.Write("\n\nFunction to calculate the sum of two numbers :\n");

            Console.Write("Enter a number: ");
            int n1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter another number: ");
            int n2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nThe sum of two numbers is : {0} \n", Sum(n1, n2));
            Console.WriteLine("\nThe Product of two numbers is : {0} \n", Prod(n1, n2));

            Console.ReadKey();
        }
    }
}
