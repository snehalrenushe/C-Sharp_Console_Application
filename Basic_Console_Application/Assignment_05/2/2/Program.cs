//2. Write the program to demonstrate the working of Unary Arithmetic Operators ?
//Ex:
//Input :
//Enter a value and res to perform operations on (a++,a--,++a,--a)
//Output :
//a is 11 and res is 10 a is 10 and res is 11 a is 11 and res is 11 a is 10 and res is 10

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a,res;

            Console.WriteLine("Enter value of a :");
            a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter value of res :");
            res = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("a is " + a++ + " res is " + --res);
            Console.WriteLine("a is " + a-- + " res is " + res++);
            Console.WriteLine("a is " + ++a + " res is " + res--);
            Console.WriteLine("a is " + --a + " res is " + ++res);

            Console.ReadKey();
        }
    }
}
