//4. Write a program to demonstrate the function overloading by changing the Data types of the parameters in c#

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _4
{
    class Program
    {
        public int Add(int a, int b, int c)
        {
            int sum = a + b + c;
            return sum;
        }

        public double Add(double a, double b, double c)
        {
            double sum = a + b + c;
            return sum;
        }

        static void Main(string[] args)
        {
            Program obj = new Program();

            int sum2 = obj.Add(1, 2, 3);
            Console.WriteLine("sum of the three " + "integer value : " + sum2);

            double sum3 = obj.Add(1.0, 2.0, 3.0);
            Console.WriteLine("sum of the three " + "double value : " + sum3);

            Console.ReadKey();
        }
    }
}
