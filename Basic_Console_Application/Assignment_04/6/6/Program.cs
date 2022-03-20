////6. Write a program in C# Sharp to find maximum occurring character in a string.
////Ex: Input string : Welcome to india
////Output : The highest frequency of the character 'a' appear as 1 time

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _6
{
    class Program
    {
        private static char getMaxOccurrenceCharacter(String str)
        {
            int[] countArray = new int[256];
            int maxValue = 0;
            char resultChar = '\0';

            for (int i = 0; i < str.Length; i++)
            {
                countArray[str[i]]++;

                if (countArray[str[i]] > maxValue)
                {
                    maxValue = countArray[str[i]];
                    resultChar = str[i];
                }
            }

            return resultChar;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string :");
            String givenStr = Console.ReadLine();

            Console.WriteLine("The character with maximum occurrence is : " + getMaxOccurrenceCharacter(givenStr));

            Console.ReadKey();
        }
    }
}
