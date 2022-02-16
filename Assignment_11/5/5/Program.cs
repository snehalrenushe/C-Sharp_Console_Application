//5. Write a program on creating multiple objects of one class in c#

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _5
{
    class Car
    {
        string color = "red";

        static void Main(string[] args)
        {
            Car myObj1 = new Car();
            Car myObj2 = new Car();
            Console.WriteLine(myObj1.color);
            Console.WriteLine(myObj2.color);

            Console.ReadKey();
        }
    }
}
