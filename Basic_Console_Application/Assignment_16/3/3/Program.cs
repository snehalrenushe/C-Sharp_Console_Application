//3. Write a program on private access modifier in c#

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _3
{
    class Parent
    {
        private int value;

        public void setValue(int v)
        {
            value = v;
        }

        public int getValue()
        {
            return value;
        }
    }

    class Program
    {

        static void Main(string[] args)
        {
            Parent obj = new Parent();

            obj.setValue(4);
            
            Console.WriteLine("Value = " + obj.getValue());
            
            Console.ReadKey();
        }
    }
}
