using Xunit;
using Exercises;

namespace Tests;
public class BankAccount_Tests
{
    [Fact]
    public void DepositWithdraw_Flow() {
        var acc = new BankAccount("Rens",100);
        Assert.True(acc.Deposit(50));
        Assert.False(acc.Withdraw(200));
        Assert.True(acc.Withdraw(120));
        Assert.Equal(30, acc.GetBalance(), 3);
    }
} 