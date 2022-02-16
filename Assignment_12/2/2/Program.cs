//Define a static method and access that through a instance.

/* Define a static method :-
                 static method (or static function) is a method defined as a member of an object but is accessible directly
                 from an API object's constructor, rather than from an object instance created via the constructor.
                 Methods called on object instances are called instance methods.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2
{
    class Program
    {
        public int calculation(int x, int y)
        {
            int val = x * y;
            return val;
        }

        static void Main(string[] args)
        {
            Program x = new Program();
            int newval = x.calculation(12, 12);
            Console.WriteLine(newval);
            Console.ReadKey();
        }
    }
}
