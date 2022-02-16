//Write a program on both read and write property using get and set accessories in c#

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2
{
    class Person
    {
        public string Name  // property
        { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Person myObj = new Person();
            myObj.Name = "Lemon";

            Console.WriteLine(myObj.Name);

            Console.ReadKey();
        }
    }
}
