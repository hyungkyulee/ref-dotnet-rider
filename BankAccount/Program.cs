using System;

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
  }
}