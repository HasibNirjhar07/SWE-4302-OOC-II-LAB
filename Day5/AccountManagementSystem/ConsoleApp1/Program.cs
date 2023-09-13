using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Account[] accounts = new Account[2];
            accounts[0] = new Current_Account(1, "Rahim", 10000, "Rahim");
            accounts[1] = new Saving_Account(2, "Karim", 20000, "Karim");
            //accounts[2] = new IslamicAccount(3, "Rahman", 30000, "Rahman");
    
                foreach (Account account in accounts)
            {
                    account.BalanceCheck();
                    account.Deposit(1000);
                    account.BalanceCheck();
                    account.Withdraw(500);
                    account.BalanceCheck();
                    Console.WriteLine("Interest: " + account.Getinterest(1000));
                }
                Console.ReadKey();



        }
    }
}
