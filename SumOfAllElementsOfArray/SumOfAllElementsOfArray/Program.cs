using System;

namespace SumOfAllElementsOfArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[100];
            int i, n, sum = 0; 
             
            Console.Write("Input the number of elements to store in the array:  ");
            n = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input {0} elements in the array:\n", n);
            for (i = 0; i < n; i++)
            {
                Console.Write("Element {0}: ",i);
                a[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (i = 0; i<n; i++)
            {
                sum +=a[i];
            }

            Console.Write("Sum of all the elementsin the array is : {0}", sum);
            Console.ReadLine();
        }
    }
}
