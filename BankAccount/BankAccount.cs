namespace BankAccount
{
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
}