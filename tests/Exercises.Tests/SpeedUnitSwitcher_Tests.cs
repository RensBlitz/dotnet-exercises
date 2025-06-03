using Xunit;
using Exercises;

namespace Tests;
public class SpeedUnitSwitcher_Tests
{
    [Fact] public void KmhToMps(){ Assert.Equal(10.0, SpeedUnitSwitcher.KmhToMps(36.0), 3); }
    [Fact] public void MpsToKmh(){ Assert.Equal(36.0, SpeedUnitSwitcher.MpsToKmh(10.0), 3); }
} 