using Xunit;
using Exercises;

namespace Tests;
public class VatCalculator_Tests
{
    [Fact]
    public void AddVat_Basic() =>
        Assert.Equal(121.0, VatCalculator.AddVat(100.0, 21.0), 3);
} 