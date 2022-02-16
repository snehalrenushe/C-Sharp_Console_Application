//6. Write a C# Sharp program that takes a character as input and check the input
//(lowercase) is a vowel, a digit, or any other symbol.
//Ex: Input : symbol : a
//Output : It is a lowercase vowel

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _6
{
    class Program
    {
        static void Main(string[] args)
        {
            char symbol;

            Console.Write("Input a symbol: ");
            symbol = Convert.ToChar(Console.ReadLine());

            if ((symbol == 'a') || (symbol == 'e') || (symbol == 'i') || (symbol == 'o') || (symbol == 'u'))
            {
                Console.WriteLine("It's a lowercase vowel.");
            }
            else if ((symbol == 'A') || (symbol == 'E') || (symbol == 'I') || (symbol == 'O') || (symbol == 'U'))
            {
                Console.WriteLine("It's a Uppercase vowel.");
            }
            else if ((symbol >= '0') && (symbol <= '9'))
            {
                Console.WriteLine("It's a digit.");
            }
            else
            {
                Console.Write("It's another symbol.");
            }

            Console.ReadKey();
        }
    }
}
