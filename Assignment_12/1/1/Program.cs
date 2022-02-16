//Define a static variable and access that through class name.


/*Defination of static variable :- 
            Static variables are used for defining constants because their values can be retrieved by invoking the class without 
            creating an instance of it. Static variables can be initialized outside the member function or class definition. 
            You can also initialize static variables inside the class definition.           
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1
{
    class Program
    {
        public static int i;
        public static void display()
        {
            i = 10;
            Console.WriteLine(i);
        }

        public void demo()
        {
            int j = 20;
            Console.WriteLine(j);
        }

        static void Main(string[] args)
        {
            Program obj = new Program();
            Program.display();
            obj.demo();
            Console.ReadKey();
        }
    }  
}
