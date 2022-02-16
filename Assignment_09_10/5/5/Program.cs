//Write a program to print entered number of even numbers in c#
//Ex:
//Input :
//Enter number : 5
//Output :
//2 4 6 10 12

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
            int i, n;

            Console.WriteLine("Enter a limit");
            n = Convert.ToInt32(Console.ReadLine());

            for (i = 0; i < n; i++)
            {
                Console.WriteLine(" " + 2*(i+1));            
            } 
                
            

            Console.ReadKey();
        }
    }
}
