//4. Write a program that converts various value types to string type
//Ex:
//Input :
//Enter Integer value
//Enter Float Value
//Output :
//int.ToString() - 75
//float.ToString()- 43.09

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _4
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            decimal d;

            Console.WriteLine("Enter Integer value : ");
            a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter float value : ");
            d = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine(a.ToString());
            Console.WriteLine(d.ToString());

            Console.ReadKey();
        }
    }
}
