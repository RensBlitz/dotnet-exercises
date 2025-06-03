using Xunit;
using Exercises;

namespace Tests;
public class FizzBuzzLite_Tests
{
    [Fact]
    public void Sequence()
    {
        var seq = FizzBuzzLite.Generate();
        Assert.Equal(20, seq.Count);
        Assert.Equal("Fizz", seq[2]);
        Assert.Equal("4",    seq[3]);
        Assert.Equal("Fizz", seq[5]);
    }
} 