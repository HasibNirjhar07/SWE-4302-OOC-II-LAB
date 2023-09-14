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
        
            try
            {
                if (Balance > 200 && amount <= Balance && amount <= 10000)
                {
                    Balance -= amount;
                    Console.WriteLine("Withdrawn successfully");
                }
                else
                {
                    throw new Exception("Invalid amount");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public override void Deposit(double amount)
        {
       
            try
            {
                if (amount > 0)
                {
                    Balance += amount;
                    Console.WriteLine("Deposited successfully");
                }
                else
                {
                    throw new Exception("Invalid amount");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }   
        }
        public override void BalanceCheck()
        {
            Console.WriteLine("Your balance is: " + Balance);
        }
        public override double Getinterest(double amount)
        {
           //accountNotSuitableforinterest
           //usingException
            try
            {
                throw new Exception("Account not suitable for interest");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return 0;
            
        }
    }
}
