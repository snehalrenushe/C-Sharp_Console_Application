//2. Write a program in C# Sharp to find the length of a string without using library function.
//Ex: Input : Jalatechnologies
//Output : 16

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
            string str;
            int x = 0;

            Console.Write("Enter Your String : ");
            str = Console.ReadLine();
            
            Console.Write("Your String is : ");

            foreach (char c in str)
            {
                Console.Write(str[x]);
                x++;
            }

            Console.WriteLine("\nLength Of String : {0}", (x));
            Console.ReadKey(); 
        }
    }
}
