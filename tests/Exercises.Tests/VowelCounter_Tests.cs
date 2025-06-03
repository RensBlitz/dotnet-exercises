using Xunit;
using Exercises;
using System.Collections.Generic;

namespace Tests;
public class VowelCounter_Tests
{
    [Fact]
    public void Count_Basic() {
        var m = VowelCounter.Count("Hello World");
        Assert.Equal(1, m['e']);
        Assert.Equal(1, m['o']);
    }
} 