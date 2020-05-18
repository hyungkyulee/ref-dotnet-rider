using System;
using NUnit.Framework;

namespace BankAccount
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("=======================");
      
      var ba = new BankAccount(100);
      ba.Deposit(50);
      Console.WriteLine(ba.Balance);
    }
    
    public class BankAccount
    {
      public int Balance { get; private set; }

      public BankAccount(int balance)
      {
        Balance = balance;
      }

      public void Deposit(int amount)
      {
        Balance += amount;
      }
    }
    
    [TestFixture]
    public class BankAccountTests
    {
      [Test]
      public void DepositTest()
      {
        var ba = new BankAccount(0);
        ba.Deposit(100);
        Assert.That(ba.Balance, Is.EqualTo(100));
      }
    }
    
  }
}