//1. Define a program on overloading by changing the Number of parameters.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1
{
    public class Area
    {
        public double area(double s)
        {
            double area = s * s;
            return area;
        }

        public double area(double l, double b)
        {
            double area = l * b;
            return area;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Area a = new Area();
            double length = 3.3;
            double breadth = 4.9;
            double rect = a.area(length, breadth);
            Console.WriteLine("Area of rectangle " + rect);

            double side = 3.3;
            double square = a.area(side);
            Console.WriteLine(square);

            Console.ReadKey();
        }
    }
}
