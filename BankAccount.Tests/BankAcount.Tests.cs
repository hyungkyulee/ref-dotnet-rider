using NUnit.Framework;

namespace BankAccount.Tests
{
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