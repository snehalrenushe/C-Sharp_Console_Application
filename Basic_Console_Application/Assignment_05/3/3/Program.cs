//3. Write the program to demonstrate the working of Relational Operators ?
//Ex:
//Input :
//Enter a and b values and result to perform operations on (==,>,<,>=,<=,!=)
//Output :
//Equal to Operator: False Greater than Operator: False Less than Operator: True Greater than or Equal to: False Lesser than or Equal to: True Not Equal to Operator: True

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            bool ischeck = true;
            bool isnotcheck = false;
            int a, b;

            Console.WriteLine("Enter First Value : ");
            a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Second Value : ");
            b = Convert.ToInt32(Console.ReadLine());

            if (a == b)
            {
                Console.WriteLine("Equal to Operator : " + ischeck);
            }
            else
            {
                Console.WriteLine("Equal to Operator : "+ isnotcheck);
            }

            if (a > b)
            {
                Console.WriteLine("Greater than Operator : " + ischeck);
            }
            else
            {
                Console.WriteLine("Greater than Operator : " + isnotcheck);
            }

            if (a < b)
            {
                Console.WriteLine("Less than Operator : " + ischeck);
            }
            else
            {
                Console.WriteLine("Less than Operator : " + isnotcheck);
            }

            if (a >= b)
            {
                Console.WriteLine("Greater than Equal Operator : " + ischeck);
            }
            else
            {
                Console.WriteLine("Greater than Equal Operator : " + isnotcheck);
            }

            if (a <= b)
            {
                Console.WriteLine("Less than Equal Operator : " + ischeck);
            }
            else
            {
                Console.WriteLine("Less than Equal Operator : " + isnotcheck);
            }

            if (a != b)
            {
                Console.WriteLine("Not Equal to Operator : " + ischeck);
            }
            else
            {
                Console.WriteLine("Not Equal to Operator : " + isnotcheck);
            }

            Console.ReadKey();
        }
    }
}
