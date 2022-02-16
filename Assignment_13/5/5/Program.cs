//5. Write a program to demonstrate the function overloading by changing the Order of the parameters in c#

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _5
{
    class Program
    {
        public void Identity(String name, int id)
        {

            Console.WriteLine("Name1 : " + name + ", " + "Id1 : " + id);
        }

        public void Identity(int id, String name)
        {

            Console.WriteLine("Name2 : " + name + ", " + "Id2 : " + id);
        }

        static void Main(string[] args)
        {
            Program obj = new Program();

            obj.Identity("Akku", 1);
            obj.Identity(2, "Abby");

            Console.ReadKey();
        }
    }
}
