using System;

namespace Demo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] arr1 = new int[] {
            54, 91, 23, 90, 4, 12, 43, 56, 49, 10
         };
            int[] arr2 = new int[10];
            int[] arr3 = new int[10];
            int i, j = 0, k = 0;

            for (i = 0; i < 10; i++)
            {
                if (arr1[i] % 2 == 0)
                {
                    arr2[j] = arr1[i];
                    j++;
                }
                else
                {
                    arr3[k] = arr1[i];
                    k++;
                }
            }

            Console.WriteLine("Even numbers...");
            for (i = 0; i < j; i++)
            {
                Console.WriteLine(arr2[i]);
            }

            Console.WriteLine("Odd numbers...");
            for (i = 0; i < k; i++)
            {
                Console.WriteLine(arr3[i]);
            }
        }
    }
}