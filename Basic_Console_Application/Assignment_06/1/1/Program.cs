//1. Write a program to Implicit Type Conversion
//Ex:
//Input :
//Enter Int value
//Enter Long value
//Output :
//Int value - 53
//Long value - 53

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
            int i = 57;
            long l = i;
            float f = l;

            Console.WriteLine("Int value " + i);
            Console.WriteLine("Long value " + l);
            Console.WriteLine("Float value " + f);

            Console.ReadKey();
        }
    }
}
