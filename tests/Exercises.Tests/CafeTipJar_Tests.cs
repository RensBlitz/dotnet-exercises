using Xunit;
using Exercises;

namespace Tests;

public class CafeTipJar_Tests
{
    [Fact]
    public void TotalWithTip_Standard() =>
        Assert.Equal(20.16, CafeTipJar.TotalWithTip(18, 12), 3);
} 