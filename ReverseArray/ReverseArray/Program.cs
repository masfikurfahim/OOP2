using System;

namespace ReverseArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, n;
            int[] a = new int[100];            
             
            Console.Write("Input the number of elements in the array: ");

            n = Convert.ToInt32(Console.ReadLine());


            Console.Write("Input {0} number of elements in the array: \n", n);
            for (i = 0; i < n; i++)
            {
                Console.Write("Element {0} : ", i);
                a[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.Write("\nThe values in the array: \n");
            for (i = 0; i<n; i++)
            {
                Console.Write("{0}    ",a[i]);
            }

            Console.Write("\nThe values in array are switched in reverse order:\n");
            for (i = n-1; i>= 0; i--)
            {
                Console.Write("{0}    ", a[i]);
            }
            Console.Write("\n");
            Console.ReadLine();
        }
    }
}
