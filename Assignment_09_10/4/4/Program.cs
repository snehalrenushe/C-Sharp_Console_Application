//4. Write a program using parameter arrays and print output in console in c#

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _4
{
    class Program
    {
        static void PlusPlus(int numFormal)
        {
            numFormal += 1;
            Console.WriteLine("Value in numFormal: {0}", numFormal);
        }  

        static void Main(string[] args)
        {
            int num = 1000;
            Console.WriteLine("Initial Value in num: {0}", num);
            PlusPlus(num);
            Console.WriteLine("Final Value in num: {0}", num);
            Console.ReadLine();  
        }
    }
}
