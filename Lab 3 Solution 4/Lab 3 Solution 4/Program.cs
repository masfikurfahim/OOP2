using System;

namespace Lab_3_Solution_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 100;
            int even = 0;
            int odd = 0;
            for (int i = 1; i <= n; i++)
            {
                if (i % 2 == 0)
                {
                    even = even + i;
                }
                else
                {
                    odd = odd + i;
                }
            }
            Console.WriteLine(even);
            Console.WriteLine(odd);

            Console.ReadLine();
        }
    }
}
