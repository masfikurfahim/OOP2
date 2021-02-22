using System;

namespace Account
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("************************Bank Management System***********************************\n");


            Console.WriteLine("\nSavings: \n");
            Savings s1 = new Savings(11456, "Masfikur", 10000);
            Savings s2 = new Savings(27945, "Fahim", 15000);
            s1.Transfer(5000, s2);
            s2.ShowInfo();

            Console.WriteLine("\nFixed Deposit Account: \n");
            Fixed f1 = new Fixed(87561, "Leo", 100000, 7);
            Fixed f2 = new Fixed(3453, "Messi", 25000, 15);
            f1.Transfer(5000, f2);
            f2.ShowInfo();

            Console.WriteLine("\nOver Draft: \n");
            OverDraft od1 = new OverDraft(71971, "Cristiano", 100000);
            OverDraft od2 = new OverDraft(65973, "Ronaldo", 50000);
            od1.Transfer(5000, od2);
            od2.ShowInfo();

            Console.WriteLine("\nSpecial Current Account: ");
            SpecialCurrent sp1 = new SpecialCurrent(24536, "Toni", 45000);
            SpecialCurrent sp2 = new SpecialCurrent(35697, "Kroos", 25000);
            sp1.Transfer(2000, sp2);
            sp2.ShowInfo();

            Console.ReadLine();
        }

    }
}