//3. By using Array write the program using For and Foreach loop in c#
//Ex:
//Input :
//Enter Array printing using for loop
//Enter Array printing using ForEach loop
//Output :
//JalaTechnologies
//JalaTechnologies

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] arr = {'S','N','E','H','A','L'};

            Console.Write("Array printing using for loop = ");

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i]);
            }

            Console.WriteLine();

            Console.Write("Array printing using foreach loop = ");

            foreach (char ch in arr)
            {
                Console.Write(ch);
            }

            Console.ReadKey();
        }
    }
}
