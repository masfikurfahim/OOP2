using System;
using System.Collections.Generic;
using System.Text;

namespace Account
{
    class SpecialCurrent : Account
    {
        private int openingBalance;
        private int minBalance;
        public SpecialCurrent()
        {

        }
        public SpecialCurrent(int accountID, string accountName, int balance)
            : base(accountID, accountName, balance)
        {
            openingBalance = balance;
            minBalance = (openingBalance * 10) / 100;
        }
        public void Transfer (int amount, Account acc)
        {
            if ((base.AccountBalance - amount) >= minBalance)
                base.Transfer(amount, acc);
            else
                Console.WriteLine("Insufficient Balance.");
        }
    }
}
