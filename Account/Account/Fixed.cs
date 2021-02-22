using System;
using System.Collections.Generic;
using System.Text;

namespace Account
{
    class Fixed : Account
    {
        private int tenureYear = 5;
        private int year;

        public int Year
        {
            get { return year; }
            set { year = value; }
        }

        public Fixed()
        {

        }
        public Fixed(int accountID, string accountName, int balance, int year)
            : base(accountID, accountName, balance)
        {
            this.year = year;
        }
        public void Transfer(int amount, Account acc)
        {
            if (tenureYear == this.year)
            {
                base.Transfer(amount, acc);
            }
            else
            {
                Console.WriteLine("Sorry, you are not eligible to transfer money. Please try again....  ");
            }
        }
    }
}
