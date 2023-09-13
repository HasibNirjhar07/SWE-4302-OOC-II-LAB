using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Current_Account:Account

    {

        public Current_Account(int accountNumber, string accountName, double balance, string signature) : base(accountNumber, accountName, balance, signature)
        {
        }
        public override void Withdraw(double amount)
        {
            if (Balance>500 && amount <= Balance && amount<=20000)
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
            return Balance * 0.08;
            
        }
    }
}
