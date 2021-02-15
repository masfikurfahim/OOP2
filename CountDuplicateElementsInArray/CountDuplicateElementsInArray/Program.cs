using System;

namespace CountDuplicateElementsInArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = new int[100];
            int[] arr2 = new int[100];
            int[] arr3 = new int[100];
            int c1, c2, num = 1, count = 0;
            int i, j;
            
            Console.Write("Input the number of elements to store in the array: ");
            c1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input {0} elements in the array:\n", c1);
            for (i = 0; i < c1; i++)
            {
                Console.Write("Element {0}: ",i);
                arr1[i] = Convert.ToInt32(Console.ReadLine());
            }
          
            for (i = 0; i < c1; i++)
            {
                arr2[i] = arr1[i];
                arr3[i] = 0;
            }
            
            for (i = 0; i < c1; i++)
            {
                for (j = 0; j < c1; j++)
                {
                    if (arr1[i] == arr2[j])
                    {
                        arr3[j] = num;
                        num++;
                    }
                }
                num = 1;
            }
          
            for (i = 0; i < c1; i++)
            {
                if (arr3[i] == 2) { count++; }
            }
            Console.Write("The number of duplicate elements is: {0} \n", count);

            Console.Write("\n");
            Console.ReadLine();
        }
    }
}
