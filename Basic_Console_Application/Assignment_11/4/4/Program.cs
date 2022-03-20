//4. Create an object of the Car class, with the name myObj. Then we print the value of the fields color and maxSpeed.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _4
{
    class Car 
    {
        string color;
        int maxSpeed;

        static void Main(string[] args)
        {
            Car myObj = new Car();
            myObj.color = "red";
            myObj.maxSpeed = 1969;

            Console.WriteLine(myObj.color);
            Console.WriteLine(myObj.maxSpeed);

            Console.ReadKey();
        }
     }
}
