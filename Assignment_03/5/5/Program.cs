//5. Write a C# Sharp program that takes three letters as input and display them in
//Reverse Order.
//Ex: Input: Enter letter: b Enter letter: a Enter letter: t Output : t a b
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _5
{
    class Program
    {
        static void Main(string[] args)
        {
            char l1, l2, l3;

            Console.Write("Input letter: ");
            l1 = Convert.ToChar(Console.ReadLine());

            Console.Write("Input letter: ");
            l2 = Convert.ToChar(Console.ReadLine());

            Console.Write("Input letter: ");
            l3 = Convert.ToChar(Console.ReadLine());

            Console.WriteLine("{0} {1} {2}", l3, l2, l1);

            Console.ReadKey();
        }
    }
}
