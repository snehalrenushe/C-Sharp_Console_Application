//4. Write a C# Sharp program that takes two numbers as input and perform an
//operation (+,-,*,x,/) on them and displays the result of that operation.
//Ex: Input : first number: 20, second number: 12
//Output : 20-12 = 8
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _4
{
    class Program
    {
        static void Main(string[] args)
        {
            int iNo1, iNo2, Sum, Sub, Mult, Div;

            Console.Write("Enter First No : ");
            iNo1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Second No : ");
            iNo2 = Convert.ToInt32(Console.ReadLine());

            Sum = iNo1 + iNo2;
            Sub = iNo1 - iNo2;
            Mult = iNo1 * iNo2;
            Div = iNo1 / iNo2;

            Console.WriteLine("Addition is : " + Sum);
            Console.WriteLine("Substraction is : " + Sub);
            Console.WriteLine("Multiplication is : " + Mult);
            Console.WriteLine("Division is : " + Div);

            Console.ReadKey();
        }
    }
}
