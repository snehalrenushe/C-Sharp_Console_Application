//Define a static and instance variable constructors and invoke the instance constructor.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _3
{
    class Program
    {
        class User
        {
            // Static Constructor
            static User()
            {
                Console.WriteLine("I am Static Constructor");
            }
            // Default Constructor
            public User()
            {
                Console.WriteLine("I am Default Constructor");
            }
        }

        static void Main(string[] args)
        {
            User user = new User();
            // Only Default constructor will invoke
            User user1 = new User();
            Console.WriteLine("\nPress Enter Key to Exit..");
            Console.ReadLine();
        }
    }
}
