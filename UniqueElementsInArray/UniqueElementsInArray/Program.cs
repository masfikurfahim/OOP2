using System;

namespace UniqueElementsInArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, ctr = 0;
            int[] arr = new int[100];
            int i, j, k;


            Console.Write("Input the number of elements to store in the array: ");

            n = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input {0} elements in the array:\n",n);
            for (i = 0; i < n; i++)
            {
                Console.Write("Element {0}: ",i);
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            
            Console.Write("The unique elements in this array are:\n");
            for (i = 0; i < n; i++)
            {
                ctr = 0;
                for (j = 0; j<i -1; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        ctr++;
                    }
                }
                
                for (k = i + 1; k <n; k++)
                {
                    
                    if (arr[i] == arr[k])
                    {
                        ctr++;
                    }
                  
                    if (arr[i] == arr[i + 1])
                    {
                        i++;
                    }
                }
              
                if (ctr == 0)
                {
                    Console.Write("{0} ", arr[i]);
                }
            }
            Console.Write("\n");
            Console.ReadLine();
        }
    }
}
