using Xunit;
using Exercises;

namespace Tests;

public class TemperatureSpread_Tests
{
    [Fact]
    public void SpreadAndAverage_Basic()
    {
        var (d, a) = TemperatureSpread.SpreadAndAverage(18, 10);
        Assert.Equal(8, d, 3);
        Assert.Equal(14, a, 3);
    }
} 