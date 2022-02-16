//3. Write a Program to calculate the length of the string using count function
//Ex: Given String: INDIA The Length of the First String is : 5

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
            string name = "Anthony";
            int nameLength = name.Length;

            Console.WriteLine("The name " + name + " contains " + nameLength + " letters.");

            Console.ReadKey();
        }
    }
}
