using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class IslamicAccount:Account
    {
        public IslamicAccount(int accountNumber, string accountName, double balance, string signature) : base(accountNumber, accountName, balance, signature)
        {
        }
        public override void Withdraw(double amount)
        {
            if (Balance > 200 && amount <= Balance && amount <= 10000)
            {
                Balance -= amount;
                Console.WriteLine("Withdrawn successfully");
            }
            else
            {
                Console.WriteLine("Invalid amount");
            }
        }
        public override void Deposit(double amount)
        {
            if (amount > 0)
            {
                Balance += amount;
                Console.WriteLine("Deposited successfully");
            }
            else
            {
                Console.WriteLine("Invalid amount");
            }
        }
        public override void BalanceCheck()
        {
            Console.WriteLine("Your balance is: " + Balance);
        }
        public override double Getinterest(double amount)
        {
            throw new NotImplementedException();
            
        }
    }
}
