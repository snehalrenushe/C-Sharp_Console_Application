//2. Define a program on changing the order of parameters using method overloading.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2
{
    class GFG 
    {
        public int Add(int a, int b, int c)
        {
            int sum = a + b + c;
            return sum;
        }
 
        public double Add(double a,
                          double b, double c)
        {
            double sum = a + b + c;
            return sum;
        }
 
        public static void Main(String[] args)
        {
            GFG ob = new GFG();
 
            int sum2 = ob.Add(1, 2, 3);
            Console.WriteLine("sum of the three " + "integer value : " + sum2);
            double sum3 = ob.Add(1.0, 2.0, 3.0);
            Console.WriteLine("sum of the three " + "double value : " + sum3);

            Console.ReadKey();
        }
    }
}
