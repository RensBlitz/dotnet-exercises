using Exercises;
using Xunit;

namespace Exercises.Tests;

public class BookPageEstimator_Tests
{
    [Fact]
    public void Estimate_40pph_90min() =>
        Assert.Equal(60, BookPageEstimator.EstimatePages(40, 90), 3);
} 