using System;
using System.Collections.Generic;
using System.Text;

namespace Account
{
    class Savings : Account
    {

        private int minBalance = 100;
        public Savings() { }

        public Savings(int accountID, string accountName, int balance)
           : base(accountID, accountName, balance)
        {

        }
        public void Transfer(int amount, Account acc)
        {
            if ((base.AccountBalance - amount) >= minBalance)
                base.Transfer(amount, acc);
            else
                Console.WriteLine("Insufficient Balance.");
        }
    }
}
