//3. Write a program on converting Float to Decimal type and print in console
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
            float fNo = 5.55f;
            decimal dNo = (decimal)fNo;

            Console.WriteLine(dNo);

            Console.ReadKey();
        }
    }
}
