namespace Exercises;
public class BankAccount
{
    private readonly string owner;
    private double balance;

    public BankAccount(string owner, double openingBalance)
    {
        // TODO
        throw new NotImplementedException();
    }
    public bool Deposit(double amount)
    {
        // TODO
        throw new NotImplementedException();
    }
    public bool Withdraw(double amount)
    {
        // prevent overdraft
        // TODO
        throw new NotImplementedException();
    }
    public double GetBalance() => balance;
} 