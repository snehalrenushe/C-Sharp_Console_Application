//2. Write an example of explicit type conversion
//Ex:
//Input :
//Enter Value of I
//Output :
//Value of I is 34

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
            double d = 765.12;
            int i = (int)d;

            Console.WriteLine("Value of i is " + i);

            Console.ReadKey();
        }
    }
}
