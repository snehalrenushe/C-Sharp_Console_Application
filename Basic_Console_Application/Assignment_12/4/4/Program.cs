//4. Define a static variable and change within the class

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _4
{
    class Program
    {
        static int x, y;
        void display()
        {
            int result = x + y;
            Console.WriteLine("the result is " + result);
        }  

        static void Main(string[] args)
        {
            Console.WriteLine("enter the numbers");
            x = Convert.ToInt16(Console.ReadLine());
            y = Convert.ToInt16(Console.ReadLine());
            Program obj = new Program();
            obj.display();
            Console.ReadLine();
        }
    }
}
