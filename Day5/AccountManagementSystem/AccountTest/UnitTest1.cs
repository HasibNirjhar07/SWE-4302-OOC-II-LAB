using ConsoleApp1;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace AccountTest
{
    [TestClass]
    public class AccountTests
    {

        [TestMethod]
        public void  SavingAccountWithdrawTest()
        {
            Account SavingAccount = new Saving_Account(1, "Rahim", 10000, "Rahim");
          
            SavingAccount.Withdraw(500);
            Assert.AreEqual(9500, SavingAccount.Balance);
          
        }
        [TestMethod]
        public void CurrentAccountWithdrawTest()
        {
            
            Account CurrentAccount = new Current_Account(2, "Karim", 20000, "Karim");
            
            CurrentAccount.Withdraw(500);
            Assert.AreEqual(19500, CurrentAccount.Balance);
           
        }
        [TestMethod]
        public void DepositTest()
        {
            Account SavingAccount = new Saving_Account(1, "Rahim", 10000, "Rahim");
            Account CurrentAccount = new Current_Account(2, "Karim", 20000, "Karim");
            Account IslamicAccount = new IslamicAccount(3, "Rahman", 30000, "Rahman");
            SavingAccount.Deposit(1000);
            Assert.AreEqual(11000, SavingAccount.Balance);
            CurrentAccount.Deposit(1000);
            Assert.AreEqual(21000, CurrentAccount.Balance);
            IslamicAccount.Deposit(1000);
            Assert.AreEqual(31000, IslamicAccount.Balance);
        }
        [TestMethod]
        public void GetInterestTest()
        {
            Account SavingAccount = new Saving_Account(1, "Rahim", 10000, "Rahim");
            Account CurrentAccount = new Current_Account(2, "Karim", 20000, "Karim");
            Account IslamicAccount = new IslamicAccount(3, "Rahman", 30000, "Rahman");
            Assert.AreEqual(1000, SavingAccount.Getinterest(10000));
            Assert.AreEqual(1600, CurrentAccount.Getinterest(20000));
            // Assert.AreEqual(300, IslamicAccount.Getinterest(1000));
        }
        [TestMethod]
        public void BalanceCheckTest()
        {
            Account SavingAccount = new Saving_Account(1, "Rahim", 10000, "Rahim");
            Account CurrentAccount = new Current_Account(2, "Karim", 20000, "Karim");
            Account IslamicAccount = new IslamicAccount(3, "Rahman", 30000, "Rahman");
            Assert.AreEqual(10000, SavingAccount.Balance);
            Assert.AreEqual(20000, CurrentAccount.Balance);
            // Assert.AreEqual(30000, IslamicAccount.Balance);
        }
        [TestMethod]
        public void SavingAccountWithdrawExceptionTest()
        {
            Account SavingAccount = new Saving_Account(1, "Rahim", 10000, "Rahim");
            // Account CurrentAccount = new Current_Account(2, "Karim", 20000, "Karim");
            // Account IslamicAccount = new IslamicAccount(3, "Rahman", 30000, "Rahman");
            try
            {
                SavingAccount.Withdraw(100000);
            }
            catch (Exception e)
            {
                Assert.AreEqual("Invalid amount", e.Message);
            }

        }
        [TestMethod]
        public void CurrentAccountWithdrawExceptionTest()
        {
            // Account SavingAccount = new Saving_Account(1, "Rahim", 10000, "Rahim");
            Account CurrentAccount = new Current_Account(2, "Karim", 20000, "Karim");
            // Account IslamicAccount = new IslamicAccount(3, "Rahman", 30000, "Rahman");
            try
            {
                CurrentAccount.Withdraw(100000);
            }
            catch (Exception e)
            {
                Assert.AreEqual("Invalid amount", e.Message);
            }
        }   
       

        [TestMethod]
        public void DepositExceptionTest()
        {
            Account SavingAccount = new Saving_Account(1, "Rahim", 10000, "Rahim");
            Account CurrentAccount = new Current_Account(2, "Karim", 20000, "Karim");
            Account IslamicAccount = new IslamicAccount(3, "Rahman", 30000, "Rahman");
            try
            {
                SavingAccount.Deposit(-100000);
            }
            catch (Exception e)
            {
                Assert.AreEqual("Invalid amount", e.Message);
            }
            try
            {
                CurrentAccount.Deposit(-100000);
            }
            catch (Exception e)
            {
                Assert.AreEqual("Invalid amount", e.Message);
            }
            try
            {
                IslamicAccount.Deposit(-100000);
            }
            catch (Exception e)
            {
                Assert.AreEqual("Invalid amount", e.Message);
            }
        }

        [TestMethod]

        public void IslamicAcInterestExceptionTest()
        {
            Account SavingAccount = new Saving_Account(1, "Rahim", 10000, "Rahim");
            Account CurrentAccount = new Current_Account(2, "Karim", 20000, "Karim");
            Account IslamicAccount = new IslamicAccount(3, "Rahman", 30000, "Rahman");
            try
            {
                IslamicAccount.Getinterest(50);
            }
            catch (Exception e)
            {
                Assert.AreEqual("Account not suitable for interest", e.Message);
            }
        }

        [TestMethod]

        public void IslamicAccountWithdrawTest()
        {
            Account IslamicAccount = new IslamicAccount(3, "Rahman", 30000, "Rahman");
            IslamicAccount.Withdraw(500);
            Assert.AreEqual(29500, IslamicAccount.Balance);

        }
    }
}
