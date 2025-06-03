using Xunit;
using Exercises;

namespace Tests;

public class SpaceProbeSignalTime_Tests
{
    [Fact]
    public void MoonDistance()
    {
        double expected = 768_800.0 / 299_792.0; // ≈2.565 s
        Assert.Equal(expected, SpaceProbeSignalTime.RoundTripSeconds(384_400), 4);
    }
} 