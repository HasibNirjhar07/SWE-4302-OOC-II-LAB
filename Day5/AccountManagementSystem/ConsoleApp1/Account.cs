using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public abstract class Account
    {

        private int AccountNumber { get; set; }
        private string AccountName { get; set; }
        public double Balance { get; set; }
        private string Signature { get; set; }

        public Account(int accountNumber, string accountName, double balance, string signature)
        {
            AccountNumber = accountNumber;
            AccountName = accountName;
            Balance = balance;
            Signature = signature;
        }

        public abstract void Withdraw(double amount);
        public abstract void Deposit(double amount);
        public abstract void BalanceCheck();

        public abstract double Getinterest(double amount);
    }
}
