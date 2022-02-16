//3. Write a program on taking one method with same but different signature in the methods in c#

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _3
{
    class Program
    {
        public int Add(int a, int b)
        {

            int sum = a + b;
            return sum;
        }

        // adding three integer value.
        public double Add(int a, int b)
        {
            double sum = a + b + 0.0;
            return sum;
        }

        static void Main(string[] args)
        {
            Program obj = new Program();

            int sum1 = obj.Add(1, 2);
            Console.WriteLine("sum of the two " + "integer value :" + sum1);

            int sum2 = obj.Add(1, 2);
            Console.WriteLine("sum of the three " + "integer value :" + sum2);
        }
    }
}
