using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _13
{
    class Program
    {
        static int removeDuplicates(int[] arr, int n)
        {

            // Return, if array is empty or contains a single element
            if (n == 0 || n == 1)
            {
                return n;
            }

            int[] temp = new int[n];

            // Start traversing elements
            int j = 0;

            for (int i = 0; i < n - 1; i++)
            {
                // If current element is not equal to next element then store that current element
                if (arr[i] != arr[i + 1])
                {
                    temp[j++] = arr[i];

                    // Store the last element as whether it is unique or repeated, it hasn't stored previously
                    temp[j++] = arr[n - 1];

                    // Modify original array
                    for (i = 0; i < j; i++)
                    {
                        arr[i] = temp[i];
                    }
                    
                }
            }
            return j;
        }

        public static void Main()
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

            N = removeDuplicates(arr, N);

            Console.WriteLine("Single Elements are : ");

            // Print updated array
            for (i = 0; i < N; i++)
            {
                Console.Write(arr[i] + " ");
            }

            Console.ReadKey();
        }
    }
}
