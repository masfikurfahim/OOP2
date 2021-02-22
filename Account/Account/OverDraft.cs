using System;
using System.Collections.Generic;
using System.Text;

namespace Account
{
    class OverDraft : Account
    {
        private int limit = 10000000;
        public OverDraft()
        {

        }
        public OverDraft(int accountID, string accountName, int balance)
            : base(accountID, accountName, balance)
        {
            base.AccountBalance = balance + limit;
        }
        public void Transfer(int amount, Account acc)
        {
            if ((base.AccountBalance) >= amount)
                base.Transfer(amount, acc);
            else
                Console.WriteLine("Insufficient Balance.");
        }
    }
}
