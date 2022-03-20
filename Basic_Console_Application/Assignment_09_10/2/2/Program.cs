//2. Write a program on static and instance methods in c#

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2
{
    class Program
    {
        public static void run()
        {
            Console.WriteLine("I'm Static method");
        }

        public void engine()
        {
            Console.WriteLine("I'm non-static/instance method!!!");
        }   

        static void Main(string[] args)
        {
            Program.run();
            Program c = new Program();
            c.engine();

            Console.ReadKey();
        }
    }
}
