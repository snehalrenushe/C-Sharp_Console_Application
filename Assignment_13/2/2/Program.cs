//2. Write a program on Runtime polymorphism in c#

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2
{
    class Program
    {
        class Shape
        {
            public virtual void Draw()
            {

            }
        }

        class Ractangel : Shape
        {
            public override void Draw()
            {
                Console.WriteLine("Rectangle Drawn ");
            }

        }

        class Circle : Shape
        {
            public override void Draw()
            {
                Console.WriteLine("Circle Drawn ");

            }

        }

        class Traingle : Shape
        {
            public override void Draw()
            {
                Console.WriteLine("Triangle Drawn ");

            }
        }

        static void Main(string[] args)
        {
            Shape[] s = new Shape[3];

            /* Polymorphic Objects */
            /* creating Array with Different types of Objects */

            s[0] = new Circle();
            s[1] = new Ractangel();
            s[2] = new Traingle();

            Console.WriteLine("\n\nRuntime polymorphism test\n\n");

            for (int i = 0; i < 3; i++)
            {
                s[i].Draw();
            }

            Console.ReadKey();
        }
    }
}
