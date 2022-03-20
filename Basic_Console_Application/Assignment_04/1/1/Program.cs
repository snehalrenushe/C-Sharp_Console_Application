//1. Write a Program to Reverse a String without using Reverse function
//Ex: Enter a String : INDIA Reverse String is : AIDNA

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
            string Str, Revstr = ""; 
            int Length; 

            Console.Write("Enter A String : "); 
            Str = Console.ReadLine(); 

            Length = Str.Length - 1; 

            while (Length >= 0) 
            {
                Revstr = Revstr + Str[Length];
                Length--;
            }

            Console.WriteLine("Reverse  String  Is  {0}", Revstr);
            Console.ReadKey(); 
        }
    }
}
