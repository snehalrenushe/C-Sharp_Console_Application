//4. Write a Program to Replace String in String using Replace function 
//Ex: Sentence Before Replacing : Sun Rises in the West Sentence After Replacing : Sun Rises in the East

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
            String s = new String('a', 3);
            Console.WriteLine("The initial string: '{0}'", s);
            s = s.Replace('a', 'b').Replace('b', 'c').Replace('c', 'd');
            Console.WriteLine("The final string: '{0}'", s);

            Console.ReadKey();
        }
    }
}
