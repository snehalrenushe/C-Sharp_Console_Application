//Write a program to enter password by converting it to char array into string print the
//Output
//Ex: Input : enter password
//Output : Password : 123

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
            string sentence = "Mahesh Chand";
            char[] charArr = sentence.ToCharArray();
            foreach (char ch in charArr)
            {

                Console.WriteLine(ch);
            }

            // Convert char array to string  
            char[] chars = new char[10];
            chars[0] = 'M';
            chars[1] = 'a';
            chars[2] = 'h';
            chars[3] = 'e';
            chars[4] = 's';
            chars[5] = 'h';
            string charsStr = new string(chars);
            string charsStr2 = new string(new char[] { 'T', 'h', 'i', 's', ' ', 'i', 's', ' ', 'a', ' ', 's', 't', 'r', 'i', 'n', 'g' });
            Console.WriteLine("Chars to string: {0}", charsStr);
            Console.WriteLine("Chars to string: {0}", charsStr2);

            Console.ReadKey();
        }
    }
}
