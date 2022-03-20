//Write a program on A class has two methods with the same name "Add" but with different input parameters 
//(the first method has three parameters and the second method has two parameters) in c#

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1
{
    class A
    {
        void print(int i, int j, float f)
        {
            Console.WriteLine("Printing int: {0}", i);

            Console.WriteLine("Printing int: {0}", j);

            Console.WriteLine("Printing float: {0}", f);
        }

        void print(double f, int j)
        {
            Console.WriteLine("Printing float: {0}", f);

            Console.WriteLine("Printing int: {0}", j);
        }

        static void Main(string[] args)
        {
            A a1 = new A();

            a1.print(5, 2, 3.4f);

            a1.print(500.263, 2);

            Console.ReadKey();
        }
    }
}

