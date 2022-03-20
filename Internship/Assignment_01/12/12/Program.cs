using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _12
{
    class Program
    {
        static void printAlter(int[] arr, int N)
        {
            //for alternate elements

            Console.Write("Alternate Elements in array are : ");

            for (int currIndex = 0; currIndex < N; currIndex++)
            {
                // If Index stores even index
                // or odd position
                if (currIndex % 2 == 0)
                {
                    Console.Write(arr[currIndex] + " ");
                }
            }
            Console.ReadKey();
        }

        static void Main(string[] args)
        {
            int N = 0;

            //To accept count of Elements
            Console.Write("How many element you want : \n");
            N = Convert.ToInt32(Console.ReadLine());

            int[] arr = new int[N];
            int i;

            //To enter Elements
            Console.Write("Enter elements in the array :\n");
            for (i = 0; i < N; i++)
            {
                Console.Write("element {0} : ", i);
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            printAlter(arr, N);
        }
        
    }
}
