//1. Write the program to demonstrate the working of Binary Arithmetic Operators ?
//Ex:
//Input :
//Enter a and b values and result to perform operations on (+,-,*,/,%)
//Output :
//Addition Operator: 15 Subtraction Operator: 5 Multiplication Operator: 50 Division Operator: 2 Modulo Operator: 0

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            int iNo1, iNo2 ,Sum,Sub,Mult,Div,Mod;

            Console.Write("Enter First Numbers : ");
            iNo1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Second Numbers : ");
            iNo2 = Convert.ToInt32(Console.ReadLine());

            Sum = iNo1 + iNo2;
            Sub = iNo1 - iNo2;
            Mult = iNo1 * iNo2;
            Div = iNo1 / iNo2;
            Mod = iNo1 % iNo2;

            Console.WriteLine("Addition is " + Sum);
            Console.WriteLine("Substraction is " + Sub);
            Console.WriteLine("Multiplication is " + Mult);
            Console.WriteLine("Division is " + Div);
            Console.WriteLine("Modulo is " + Mod);

            Console.ReadKey();
        }
    }
}
