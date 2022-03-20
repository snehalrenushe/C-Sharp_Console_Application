//Declare a 2 strings as input and contacenate with another string with the both
//Strings and get Output
//Ex: Input : enter firstname , enter lastname , "Hello" + firstname + lastname
//Output: Hello firstname lastname

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
            string firstname, lastname;

            Console.WriteLine("Enter Firstname :");
            firstname = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Enter Lastname :");
            lastname = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Hello " + firstname + " " + lastname);

            Console.ReadKey();
        }
    }
}
