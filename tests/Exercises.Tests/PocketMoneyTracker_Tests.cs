using Xunit;
using Exercises;

namespace Tests;

public class PocketMoneyTracker_Tests
{
    [Fact]
    public void CalculateTotal_Returns8() =>
        Assert.Equal(8, PocketMoneyTracker.CalculateTotal(5, 3));
} 