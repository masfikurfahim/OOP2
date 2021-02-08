using System;

namespace Lab_3_Solution_8
{
    class Program
    {
        static void Main(string[] args)
        {
            float Physics = 80f;
            float Chemistry = 85f;
            float Biology = 75f;
            float Math = 70f;
            float Computer = 100f;
            float result = (Physics + Chemistry + Biology + Math + Computer)/5;
            Console.WriteLine("Total Marks " + result);
            if (result >= 90) { Console.WriteLine("Grade A+"); }
            else if (result >= 85 && result < 90) { Console.WriteLine("Grade A"); }
            else if (result >= 80 && result < 85) { Console.WriteLine("Grade B+"); }
            else if (result >= 75 && result < 80) { Console.WriteLine("Grade B"); }
            else if (result >= 50 && result < 75) { Console.WriteLine("Grade C+"); }
            else { Console.WriteLine("Grade F"); }
        }
    }
}