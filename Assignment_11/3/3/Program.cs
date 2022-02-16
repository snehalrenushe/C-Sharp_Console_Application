//3. Create a Car class with three class members and two fields and one method in c#

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _3
{
    class Car
    {
        string model;
        string color;
        int year;

        static void Main(string[] args)
        {
            Car Ford = new Car();
            Ford.model = "Mustang";
            Ford.color = "red";
            Ford.year = 1969;

            Car Opel = new Car();
            Opel.model = "Astra";
            Opel.color = "white";
            Opel.year = 2005;

            Console.WriteLine(Ford.model);
            Console.WriteLine(Opel.model);
            Console.WriteLine(Opel.color);
            Console.WriteLine(Ford.year);

            Console.ReadKey();
        }
    }
}
