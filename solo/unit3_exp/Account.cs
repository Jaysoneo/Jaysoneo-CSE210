using System;
using System.Collections.Generic;
namespace bank_example
{
    public class Account
    {
        //
        private List<int> transactions = new List<int>;
        public int balance = 0;

        public void Deposit(int amount)
        {
            if (amount >0 && amount < 1000)
            {
                transactions.Add(amount);
            }
            else
            {
                Console.WriteLine("Amount should be >0 and <1000");
            }
        }
        public void Withdraw(int amount)
        {
            if (amount < GetBalance());
            {
                Console.WriteLine("Amount should be less than balance");
            }
            else if (amount > 0 && amount < 500)
            {
                transactions.Add(-amount);
            }
            else{Console.WriteLine("amount should be >0 and < 500");}
        }
        public void getTransactions()
        {
            return transactions;
        }

    }
}
