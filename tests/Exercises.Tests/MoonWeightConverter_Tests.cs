using Xunit;
using Exercises;

namespace Tests;

public class MoonWeightConverter_Tests
{
    [Fact]
    public void ToMoonWeight_SixtyKg() =>
        Assert.Equal(9.9, MoonWeightConverter.ToMoonWeight(60), 3);
} 