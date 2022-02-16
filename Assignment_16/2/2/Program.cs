//2. Write a program on protected access modifier using one method in c#
//Ex:
//Input :
//Enter value of x
//Output :
//10

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2
{
    class X
    {
        protected int x;

        public X()
        {
            x = 10;
        }
    }

    class Y : X
    {
        public int getX()
        {
            return x;
        }
    }

    class Program
    {

        static void Main(string[] args)
        {
            X obj1 = new X();
            Y obj2 = new Y();

            Console.WriteLine("Value of x is : {0}", obj2.getX());
            Console.ReadKey();
        }
    }
}
