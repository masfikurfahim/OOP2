using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_3
{
    class Account
    {
        private string accName;
        private string acid;
        private int balance;

        public Account()
        {
            Console.WriteLine("\nAccount Class\n");
            balance = 0;
        }

        public void Deposit(int amount)
        {
            if (amount>0)
            {
                balance += amount;
                Console.WriteLine("The amount {0} is deposited. + Your new Balance is {1}.", amount, balance);
            }
            else
            {
                Console.WriteLine("Invalid Amount!");
            }
        }

        public void Withdraw(int amount)
        {
            if (amount > 0 && amount <= balance)
            {
                balance -= amount;
                Console.WriteLine("The amount {0} is withdraw. + Your new Balance is {1}.", amount, balance);
            }
            else
            {
                Console.WriteLine("Invalid Amount!");
            }
        }

        public string AccName
        {
            set
            {
                accName = value;
            }
            get
            {
                return accName;
            }
        }

        public string Acid
        {
            set
            {
                acid = value;
            }
            get
            {
                return acid;
            }
        }

        public int Balance
        {
            get
            {
                return balance;
            }
        }
    }
}
